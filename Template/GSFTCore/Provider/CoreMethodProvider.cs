using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Template.GSFTCore.GSFTDAL.GSFTPivotal;

namespace Template.GSFTCore.Provider
{
    public class CoreMethodProvider
    {
        private PIVDAL _provider;
        private static readonly object _GSFTDALLock = new object();
        public PIVDAL GSFTProvider
        {
            get
            {
                lock (_GSFTDALLock)
                {
                    return _provider ?? (_provider = new PIVDAL());
                }
            }
        }
    }
}