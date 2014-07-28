using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.Controllers
{
    public class BaseController : Controller
    {

        //Property to get our order
        private Models.Order _myOrder;
        public Models.Order MyOrder
        {
            get
            {
                //see if _myOrder is null
                if (_myOrder == null)
                {
                    //get the order from the database 
                    _myOrder = db.Orders.Find(GetOrderID());
                }
                return _myOrder;
            }
        }
        //set up a database connection
        public Models.eCommerceEntities db = new Models.eCommerceEntities();

        //get the orderID
        public int GetOrderID()
        {
            if (Session["orderID"] == null)
            {
                //they don't have an orderID, create a new order

                //step 1: make a new order object
                Models.Order order = new Models.Order();
                //step 2: fill in required information
                order.DateCreated = DateTime.Now;
                order.Status = "Cart";
                order.Tax = 0;
                order.Total = 0;
                order.ShippingTotal = 0;
                //step 3: add order to the database
                db.Orders.Add(order);
                //step 4: save changes 
                db.SaveChanges();
                //step 5: set the session variable for the orderID
                Session["orderID"] = order.OrderID;
            }
            //convert the session object to a string, then to an interger
            return int.Parse(Session["orderID"].ToString());
        }

    }
}
