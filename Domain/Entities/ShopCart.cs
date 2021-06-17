using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Podcast.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Podcast.Domain.Entities
{
    public class ShopCart
    {
        private readonly ApplicationDbContext applicationDbContext;
        public string ShopCartId { get; set; }

        public List<ShopCartItem> shopCartItems { get; set; }

        public ShopCart(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }


        public static ShopCart GetShopCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<ApplicationDbContext>();
            string shopCartId = session.GetString("CardId") ?? Guid.NewGuid().ToString();
            session.SetString("CardId", shopCartId);

            return new ShopCart(context) { ShopCartId = shopCartId };
        }

        public void AddToShopCart(ShopCartViewModel sc)
        {
            this.applicationDbContext.ShopCartItems.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                Podcast = sc.Podcast,
                Message = sc.Message,
                Duration = sc.Duration,
                PremierTime = sc.PremierTime,
                Price = sc.Podcast.PodcastPrice
            }) ;

            this.applicationDbContext.SaveChanges();
        }

        public List<ShopCartItem> ShopCartItemsList()
        {
            return applicationDbContext.ShopCartItems.Where(c => c.ShopCartId == ShopCartId).Include(s => s.Podcast).ToList();
        }



    }
}
