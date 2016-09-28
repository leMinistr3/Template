using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Template.GSFTCore.Session;
using Template.GSFTCore.Template;
using Template.Template.Models.Master;

namespace Template.Template.Utility
{
    public class MasterUtility
    {
        /// <summary>
        /// Get the Widget List of your page
        /// </summary>
        /// <param name="viewModel"></param>
        public void GetRequestedPage(Master_VM viewModel)
        {
            // When you do not have PageName return the Home Page
            PageItem requestPage = (viewModel.pageName != null) ?
                ApplicationSession.PageList.SingleOrDefault(m => m.Name == viewModel.pageName) :
                ApplicationSession.PageList.SingleOrDefault(m => m.IsHomePage);

            if (requestPage != null)
            {
                //Get the View to Render
                viewModel.viewName = requestPage.ViewName;
                // Get the Wiget list of the Requested page from your Application Session Item
                viewModel.widgetList = requestPage.WidgetList;
            }
        }
    }
}