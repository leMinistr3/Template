using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Template.GSFTCore.Model;
using Template.GSFTCore.Provider;

namespace Template.GSFTCore.Methods
{
    public partial class GSFTMethods : CoreMethodProvider
    {
        public Page GetPage(byte[] id)
        {
            Page item = new Page();
            item.ConvertDynamicContent(GSFTProvider.GetDataRow(id, ""), "");

            return item;
        }
    }
}