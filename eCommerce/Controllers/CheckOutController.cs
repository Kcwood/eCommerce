using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.Controllers
{
    public class CheckOutController : Controller
    {
        //
        // GET: /CheckOut/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ShippingAddress()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ShippingAddress()
        {
            return View();
        }

        [HttpGet]
        public ActionResult BillingAddress()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BillingAddress()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Payment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Payment()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Review()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Review()
        {
            return View();
        }

    }
}
