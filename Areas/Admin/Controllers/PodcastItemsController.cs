using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Podcast.Domain;
using Podcast.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Podcast.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PodcastItemsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;

        public PodcastItemsController(DataManager dataManager, IWebHostEnvironment webHostEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = webHostEnvironment;
        }

        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new PodcastItem() : dataManager.podcasts.GetPodcastItem(id);
            return View(entity);
        }



        [HttpPost]
        public IActionResult Edit(PodcastItem model, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    model.PathToPhoto = titleImageFile.FileName;
                    using (var stream = new FileStream(Path.Combine(hostingEnvironment.WebRootPath, "img/", titleImageFile.FileName), FileMode.Create))
                    {
                        titleImageFile.CopyTo(stream);
                    }
                }
                dataManager.podcasts.SavePodcastItem(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", ""));
            }
            return View(model);
        }


        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.podcasts.DeletePodcastItem(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller",""));
        }

    }
}
