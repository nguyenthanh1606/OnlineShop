using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Web.Models
{
    public class TagVM
    {
        public string ID { set; get; }

        public string Name { set; get; }

        public string Type { set; get; }

        public virtual IEnumerable<PostTagVM> PostTags { set; get; }

        public virtual IEnumerable<ProductTagVM> ProductTags { set; get; }
    }
}