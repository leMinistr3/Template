using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Template.GSFTCore.GSFTAttribute;
using Template.GSFTCore.Provider;

namespace Template.GSFTCore.Model
{
    public class Page : CoreModelProvider
    {
        // Default Properties
        private byte[] _page_Id;
        [PrimaryKey]
        public byte[] Page_Id
        {
            get { return _page_Id; }
            set { SetProperty(ref _page_Id, value); }
        }

        // Additional Properties
        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private string _viewName;
        public string ViewName
        {
            get { return _viewName; }
            set { SetProperty(ref _viewName, value); }
        }

        private string _isHomePage;
        public string IsHomePage
        {
            get { return _isHomePage; }
            set { SetProperty(ref _isHomePage, value); }
        }
    }
}