using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Podcast.Domain.Repository.Abstract;

namespace Podcast.Domain
{
    public class DataManager
    {
        public IPodcastItemRepository podcasts { get; set; }
        public IAllOrders allOrders { get; set; }
        public IAllOrderDetails orderDetails { get; set; }
        public DataManager(IPodcastItemRepository p,IAllOrders ao,IAllOrderDetails iad)
        {
            podcasts = p;
            allOrders = ao;
            orderDetails = iad;
        }
    }
}
