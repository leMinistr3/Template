using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Template.GSFTCore.GSFTDAL.GSFTPivotal
{
    public partial class PIVDAL
    {
        private List<DataTable> _tables;
        private static readonly object _tablesLock = new object();
        protected List<DataTable> Tables
        {
            get
            {
                lock (_tablesLock)
                {
                    return _tables ?? (_tables = new List<DataTable>());
                }
            }
        }

        /// <summary>
        /// Get a reccor assosiated with a table name and a id
        /// </summary>
        /// <param name="tableName">The name of the table</param>
        /// <param name="id">The id of the row</param>
        /// <returns></returns>
        public DataRow GetDataRow(byte[] id, string tableName)
        {
            try
            {
                return new DataRow();
                // Use pivotal to Get your DataRow and add the Table and the row to the List of Table
                // If the Table is Already there check if the row exist, if not add it, if yes update the row
            }
            catch { throw; }
        }
    }
}