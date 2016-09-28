using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Template.GSFTCore.Template
{
    public class PageItem
    {
        public byte[] PageId { get; set; }
        public string Name { get; set; }
        public string ViewName { get; set; }
        public bool IsHomePage { get; set; }

        public List<WidgetItem> WidgetList { get; set; }
    }
}