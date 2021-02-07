using eatsy_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eatsy_app.Repositories
{
    public class PaymentTypeRepository
    {
        private RestaurantDBEntities objRestaurantDbEntities; 


        public PaymentTypeRepository()
        {
            objRestaurantDbEntities = new RestaurantDBEntities();

        }

        public IEnumerable<SelectListItem> GetAllPaymentTypes()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objRestaurantDbEntities.PaymentTypes
                                  select new SelectListItem()
                                  {
                                      Text = obj.PaymentTypeName,
                                      Value = obj.PaymentTypeID.ToString(),
                                      Selected = true 


                                  }).ToList();

            return objSelectListItems; 

        }



    }
}