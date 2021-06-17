using Podcast.Domain.Entities;
using Podcast.Domain.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Podcast.Domain.Repository.EntityFramework
{
    public class EFAllOrderDetailsRepository : IAllOrderDetails
    {
        private readonly ApplicationDbContext applicationDbContext;

        public EFAllOrderDetailsRepository(ApplicationDbContext a)
        {
            applicationDbContext = a;
        }

        public IQueryable<OrderDetails> allOrderDetails()
        {
            return applicationDbContext.AllOrderDetails;
        }
    }
}
