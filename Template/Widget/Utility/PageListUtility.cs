using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Template.GSFTCore.Provider;
using Template.Widget.Models.PageList;

namespace Template.Widget.Utility
{
    public class PageListUtility: ApplicationProvider
    {
        public List<PageGridItem> GetPageGridItems()
        {
            return new List<PageGridItem>();
        }
    }
}