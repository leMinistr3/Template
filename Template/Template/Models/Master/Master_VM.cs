using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Specialized;
using Template.GSFTCore.Template;

namespace Template.Template.Models.Master
{
    public class Master_VM
    {
        public string pageName { get; set; }
        public string viewName { get; set; }
        public List<WidgetItem> widgetList { get; set; }
    }
}