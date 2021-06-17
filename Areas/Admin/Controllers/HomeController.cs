using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Podcast.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Podcast.Domain.Entities;
using Podcast.Domain.Repository.Abstract;
using Microsoft.AspNetCore.Authorization;

namespace Podcast.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {

        private readonly DataManager dataManager;

        public HomeController(DataManager podcastItemRepository)
        {
            this.dataManager = podcastItemRepository;
        }


        public IActionResult Details(Order order)
        {
            var items = dataManager.orderDetails.allOrderDetails().Where(i => i.OrderId == order.Id);
            foreach(var el in items)
            {
                el.Podcast = dataManager.podcasts.GetPodcastItem(el.PodcastId);
            }
            return View(items);
        }

        public IActionResult Orders()
        {
            return View(dataManager.allOrders.orders());
        }
        
        public IActionResult Index()
        {
            return View(dataManager.podcasts.GetPodcastItems());
        }
    }
}
