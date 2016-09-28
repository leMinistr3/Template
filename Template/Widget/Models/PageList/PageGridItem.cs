using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace Template.Widget.Models.PageList
{
    public class PageGridItem
    {
        public byte[] PageId { get; set; }
        public string Name { get; set; }
        public string ViewName { get; set; }
        public bool IsHomePage { get; set; }
    }
}