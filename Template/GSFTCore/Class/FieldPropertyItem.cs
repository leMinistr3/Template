using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Template.GSFTCore.Class
{
    public class FieldPropertyItem
    {
        // Fields
        public string FieldName { get; set; }
        public PropertyDescriptor PropertyDescriptor { get; set; }
        public bool IsPrimaryKey { get; set; }
    }
}