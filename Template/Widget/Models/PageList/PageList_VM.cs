using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Template.Widget.Models.PageList
{
    public class PageList_VM
    {
        // LDGroup Declaration - Required property for setting the labels using the SetLabels Method
        public string[] resourceFile
        {
            get
            {
                return new string[] { "PageList_Group" };
            }
        }

        List<PageGridItem> pageGridItemList { get; set; }

        public string label_Name { get; set; }
        public string label_ViewName { get; set; }
        public string label_IsHomePage { get; set; }
        public string label_Action { get; set; }
    }
}