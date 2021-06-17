using Podcast.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Podcast.Domain.Repository.Abstract
{
    public interface IAllOrderDetails
    {
        public IQueryable<OrderDetails> allOrderDetails();
    }
}
