using Podcast.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Podcast.Domain.Repository.Abstract
{
    public interface IAllOrders
    {
        public void CreateOrder(Order order);

        public IQueryable<Order> orders();
    }
}
