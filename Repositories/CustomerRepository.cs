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

        private RestaurantDBEntities objRestaurantDbEntities;


        public CustomerRepository()
        {
            objRestaurantDbEntities = new RestaurantDBEntities();

        }
        // importing boostrap js module
        public IEnumerable<SelectListItem> GetAllCustomers()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objRestaurantDbEntities.Customers
                                  select new SelectListItem()
                                  {
                                      Text = obj.CustomerName,
                                      Value = obj.CustomerID.ToString(),
                                      Selected = true


                                  }).ToList();

            return objSelectListItems;

        }
    }
}