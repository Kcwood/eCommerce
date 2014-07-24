using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.Controllers
{
    public class SupplierController : Controller
    {
        //
        // GET: /Supplier/

        Models.eCommerceEntities db = new Models.eCommerceEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Detail()
        {
            return View();
        }
    }
}
