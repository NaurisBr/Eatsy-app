using eatsy_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eatsy_app.Repositories
{
    public class ItemRepository
    {
        private RestaurantDBEntities objRestaurantDbEntities;


        public ItemRepository()
        {
            objRestaurantDbEntities = new RestaurantDBEntities();

        }

        //Iterates over all entries in the database for ItemId
        //asorting items
        public IEnumerable<SelectListItem> GetAllItems()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objRestaurantDbEntities.Items
                                  select new SelectListItem()
                                  {
                                      Text = obj.ItemName,
                                      Value = obj.ItemID.ToString(),
                                      Selected = false


                                  }).ToList();

            return objSelectListItems;

        }
    }
}