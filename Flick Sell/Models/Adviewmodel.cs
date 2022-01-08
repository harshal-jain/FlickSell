using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Flick_Sell.Models
{
    public class Adviewmodel
    {

        // tbl_product

        public int prod_id { get; set; }
        public string prod_name { get; set; }
        public string prod_image { get; set; }
        public string pro_des { get; set; }
        public Nullable<int> pro_price { get; set; }
        public Nullable<int> pro_fk_user { get; set; }
        public Nullable<int> pro_fk_cat { get; set; }

        //tbl_category

        public int cat_id { get; set; }
        public string cat_name { get; set; }

        //tbl_user

        public string u_name { get; set; }
        public string u_image { get; set; }
        public string u_contact { get; set; }



    }
}