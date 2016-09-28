using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Template.GSFTCore.Methods;

namespace Template.GSFTCore.Provider
{
    /// <summary>
    /// External utilities mainly inherits from this class which allow access to a variety of functionalities
    /// </summary>
    public class ApplicationProvider
    {
        private GSFTMethods _methods;
        private static readonly object _methodLock = new object();
        public GSFTMethods GSFTApplication
        {
            get
            {
                lock (_methodLock)
                {
                    return _methods ?? (_methods = new GSFTMethods());
                }
            }
        }
    }
}