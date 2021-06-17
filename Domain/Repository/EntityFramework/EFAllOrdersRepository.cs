using Podcast.Domain.Entities;
using Podcast.Domain.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Podcast.Domain.Repository.EntityFramework
{
    public class EFAllOrdersRepository : IAllOrders
    {
        private readonly ApplicationDbContext applicationDbContext;
        private ShopCart shopCart;

       

        public EFAllOrdersRepository(ApplicationDbContext ap, ShopCart sc)
        {
            this.applicationDbContext = ap;
            this.shopCart = sc;
        }

        public IQueryable<Order> orders()
        {
            var el = applicationDbContext.Orders;
            return el;
        }


        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            applicationDbContext.Orders.Add(order);

            var items = shopCart.shopCartItems;

            foreach(var el in items)
            {
                var orderDetail = new OrderDetails()
                {
                    PodcastId = el.Podcast.Id,
                    OrderId = order.Id,
                    Price = el.Podcast.PodcastPrice,
                    Message = el.Message,
                    Duration = el.Duration,
                    Period = el.PremierTime
                };
                applicationDbContext.AllOrderDetails.Add(orderDetail);
            }

            applicationDbContext.SaveChanges();
        }


    }
}
