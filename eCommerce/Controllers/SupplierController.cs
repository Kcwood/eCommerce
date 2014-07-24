﻿using System;
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
            return View(db.Suppliers.OrderBy(x=>x.Name));
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Models.Supplier());
        }

        [HttpPost]
        public ActionResult Create(Models.Supplier supplier)
        {
            db.Suppliers.Add(supplier);
            db.SaveChanges();
            return RedirectToAction("Index", "Home"); 
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Models.Supplier supplierToDelete = db.Suppliers.Find(id);
            return View(supplierToDelete);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Models.Supplier supplierToDelete = db.Suppliers.Find(id);
            db.Suppliers.Remove(supplierToDelete);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Models.Supplier supplierToEdit = db.Suppliers.Find(id);
            return View(supplierToEdit);
        }

        [HttpPost]
        public ActionResult Edit(Models.Supplier supplierToEdit)
        {
            db.Entry(supplierToEdit).State = System.Data.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Detail()
        {
            return View();
        }
    }
}
