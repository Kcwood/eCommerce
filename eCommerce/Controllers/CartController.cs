using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.Controllers
{
    public class CartController : BaseController
    {
        //
        // GET: /Cart/

        public ActionResult Index()
        {
            return View();
        }

        //Get/Cart/MiniCart
        public ActionResult MiniCart()
        {
            //returns a partial vieew for use in the header
            return PartialView(this.MyOrder);
        }

        [HttpPost]
        public ActionResult Add(Models.OrderLine ol)
        {
            if (this.MyOrder.OrderLines.Where(x => x.ProductID == ol.ProductID).Any())
            {
                var cartItem = this.MyOrder.OrderLines.Where(x => x.ProductID == ol.ProductID).First();
                cartItem.Qty = cartItem.Qty + ol.Qty;
            }
            else
            {
                this.MyOrder.OrderLines.Add(ol);
            }
            db.SaveChanges();
            return RedirectToAction("MiniCart", "Cart");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var toDelete = MyOrder.OrderLines.Where(x => x.ProductID == id).First();
            db.OrderLines.Remove(toDelete);
            db.SaveChanges();
            return RedirectToAction("Index", "Cart");
        }



    }
}
