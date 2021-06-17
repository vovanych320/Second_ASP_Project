using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Podcast.Domain;
using Podcast.Domain.Entities;
using Podcast.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Podcast.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataManager dataManager;
        public HomeController(ILogger<HomeController> logger, DataManager dataManager)
        {
            _logger = logger;
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> Podcasts()
        {
            var pods = dataManager.podcasts.GetPodcastItems();
            var SearchFiltersVM = new SearchFiltersViewModel
            {
                Podcasts = await pods.ToListAsync()
            };

            return View(SearchFiltersVM);
        }


        [HttpPost]
        public async Task<IActionResult> Podcasts(SearchFiltersViewModel searchFiltersViewModel)
        {
            var pods = dataManager.podcasts.GetPodcastItems();
            double prc = Convert.ToDouble(searchFiltersViewModel.PodcastPrice);



            if (!String.IsNullOrEmpty(searchFiltersViewModel.SearchString))
            {
                pods = pods.Where(y => y.PodcastName.Contains(searchFiltersViewModel.SearchString));
            }

            if (!String.IsNullOrEmpty(searchFiltersViewModel.PodcastCategory))
            {
                if (searchFiltersViewModel.PodcastCategory == "Будь-яка" || searchFiltersViewModel.PodcastCategory == "Оберіть категорію")
                {
                    pods = dataManager.podcasts.GetPodcastItems();
                }
                else
                {
                    pods = pods.Where(s => (s.PodcastTopic == searchFiltersViewModel.PodcastCategory));
                }
            }

            if (!Double.IsNaN(prc) && prc > 0) 
            {
                
                pods = pods.Where(x => (x.PodcastPrice <= prc));
            }
            

            var SearchFiltersVM = new SearchFiltersViewModel
            {
                Podcasts = await pods.ToListAsync()
            };

            return View(SearchFiltersVM);
        }







        public IActionResult Details(PodcastItem  model)
        {
            
            return View(dataManager.podcasts.GetPodcastItem(model.Id));
        }


        

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Contacts()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
