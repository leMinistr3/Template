using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Template.GSFTCore.Template
{
    public class WidgetItem
    {
        public string Controller { get; set; }
        public string ControllerShortName { get; set; }
        public string DefaultAction { get; set; }
        public string Name { get; set; }
        public int? Ordinal { get; set; }
        public string PositionName { get; set; }
    }
}