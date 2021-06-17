using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Podcast.Domain;
using Podcast.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Podcast.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly DataManager dataManager;
        private readonly ShopCart shopCart;


        public OrderController(DataManager d, ShopCart sc)
        {
            this.dataManager = d;
            this.shopCart = sc;
        }

        public IActionResult CheckOut()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckOut(Order order)
        {
            shopCart.shopCartItems = shopCart.ShopCartItemsList();
            if(shopCart.shopCartItems.Count == 0)
            {
                ModelState.AddModelError("", "У вас повинні бути товари");
            }

            if(ModelState.IsValid)
            {
                dataManager.allOrders.CreateOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }


        public IActionResult Complete()
        {
            ViewBag.Message = "Замовлення успішно виконано.З вами зв'яжуться у найближчий момент.";
            return View();

        }
    }
}
