using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Podcast.Domain;
using Podcast.Domain.Entities;
using Podcast.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Podcast.Controllers
{
    [Authorize]
    public class ShopCartController : Controller
    {
        private readonly DataManager dataManeger;
        private readonly ShopCart shopCart;

        public ShopCartController(DataManager d, ShopCart sc)
        {
            dataManeger = d;
            shopCart = sc;
        }


        public ViewResult Index()
        {
            var items = shopCart.ShopCartItemsList();
            shopCart.shopCartItems = items;

            return View(shopCart);
        }

        public IActionResult ShopCartDetails(PodcastItem pd)
        {
            return View(new ShopCartViewModel { Podcast = dataManeger.podcasts.GetPodcastItem(pd.Id) });
        }


        public RedirectToActionResult AddToCart(ShopCartViewModel pd,Guid Id)
        {
            pd.Podcast = dataManeger.podcasts.GetPodcastItem(Id);
            if (pd != null)
            {
                shopCart.AddToShopCart(pd);
            }

            return RedirectToAction("Index");
        }

    }
}
