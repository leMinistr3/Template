using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Template.GSFTCore.Enumeration;
using Template.GSFTCore.Template;
using Template.Template.Models.Master;

namespace System.Web.Mvc.Html
{
    public static class GSFTHtmlHelpers
    {
        /// <summary>
        /// Render a Widget from a from a Position or a Name
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="from">From Position or Name</param>
        /// <param name="widget">Widget position or Name</param>
        /// <returns></returns>
        public static MvcHtmlString RenderWidget(this HtmlHelper helper, WidgetFrom from, string widget)
        {
            try
            {
                // Get your viewModel
                Master_VM viewModel = (Master_VM)helper.ViewData.Model;
                // Get the good widget depending if its from the position or the Name
                WidgetItem widgetItem = (WidgetFrom.Name == from) ? viewModel.widgetList.Single(m => m.Name == widget) : viewModel.widgetList.Single(m => m.PositionName == widget);

                return helper.Action(widgetItem.DefaultAction, widgetItem.ControllerShortName);
            }
            catch { }

            return null;
        }
    }
}