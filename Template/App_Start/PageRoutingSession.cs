using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Template.GSFTCore.Template;

namespace Template.App_Start
{
    public static class PageRoutingSession
    {
        public static List<PageItem> GetPageList()
        {
            return TempGetPageExemple();
        }

        public static List<PageItem> TempGetPageExemple()
        {
            List<PageItem> pageList = new List<PageItem>();
            List<WidgetItem> widgetList = new List<WidgetItem>();

            PageItem page1 = new PageItem();

            page1.WidgetList = new List<WidgetItem>();
            page1.Name = "LoginPage";
            page1.ViewName = "LoginTemplate";
            page1.IsHomePage = true;

            PageItem page2 = new PageItem();

            page2.WidgetList = new List<WidgetItem>();
            page2.Name = "InfoPage";
            page2.ViewName = "LoginTemplate";

            WidgetItem widget1 = new WidgetItem();

            widget1.Name = "Login";
            widget1.PositionName = "Left";
            widget1.Controller = "LoginController";
            widget1.ControllerShortName = "Login";
            widget1.DefaultAction = "Index";

            WidgetItem widget2 = new WidgetItem();

            widget2.Name = "News";
            widget2.PositionName = "Right";
            widget2.Controller = "NewsController";
            widget2.ControllerShortName = "News";
            widget2.DefaultAction = "Index";

            WidgetItem widget3 = new WidgetItem();

            widget3.Name = "Info";
            widget3.PositionName = "Right";
            widget3.Controller = "InfoController";
            widget3.ControllerShortName = "Info";
            widget3.DefaultAction = "Index";

            WidgetItem widget4 = new WidgetItem();

            widget4.Name = "PageList";
            widget4.PositionName = "Right";
            widget4.Controller = "PageListController";
            widget4.ControllerShortName = "PageList";
            widget4.DefaultAction = "Index";

            page1.WidgetList.Add(widget1);
            page1.WidgetList.Add(widget4);

            page2.WidgetList.Add(widget1);
            page2.WidgetList.Add(widget3);

            pageList.Add(page1);
            pageList.Add(page2);

            return pageList;
        }
    }
}