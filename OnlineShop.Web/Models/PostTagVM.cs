using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Web.Models
{
    public class PostTagVM
    {
        public int PostID { set; get; }

        public string TagID { set; get; }

        public virtual PostVM Post { set; get; }

        public virtual TagVM Tag { set; get; }
    }
}