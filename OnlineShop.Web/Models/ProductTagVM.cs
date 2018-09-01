using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Web.Models
{
    public class ProductTagVM
    {
        public int ProductID { set; get; }

        public string TagID { set; get; }

        public virtual ProductVM Product { set; get; }

        public virtual TagVM Tag { set; get; }
    }
}