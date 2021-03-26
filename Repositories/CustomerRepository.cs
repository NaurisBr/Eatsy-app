using eatsy_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eatsy_app.Repositories
{
    public class CustomerRepository
    {
        //padding out columns
        private RestaurantDBEntities objRestaurantDbEntities;

        //creating customer repository
        public CustomerRepository()
        {
            objRestaurantDbEntities = new RestaurantDBEntities();

        }
        // importing boostrap js module
        //retreiving all customer details
        public IEnumerable<SelectListItem> GetAllCustomers()
        {
            //saving selected items 
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objRestaurantDbEntities.Customers
                                  select new SelectListItem()
                                  {
                                      Text = obj.CustomerName,
                                      Value = obj.CustomerID.ToString(),
                                      Selected = true


                                  }).ToList();


            //returning selected list items
            return objSelectListItems;

        }
    }
}