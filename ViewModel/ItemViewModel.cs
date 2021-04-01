using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eatsy_app.ViewModel
{ //Completing item view model
    public class ItemViewModel
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }


        // identical to sql server table fields
    }
}