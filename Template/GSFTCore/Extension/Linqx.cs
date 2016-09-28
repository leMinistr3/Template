using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Template.GSFTCore.Class;
using Template.GSFTCore.Provider;

namespace System.Linq
{
    public static class Linqx
    {
        public static void ConvertDynamicContent<T>(this T t, DataRow row, string contentType, List<string> listPropertyName = null)
        {
            try
            {
                // Retrieve the list of field property descriptors
                List<FieldPropertyItem> listFieldPropertyInfo = FieldPropertyProvider.Instance.GetFieldPropertyListing(typeof(T), row).ToList();
                if (listPropertyName != null)
                {
                    //Get the PrimaryKey Field Name
                    string primaryKey = listFieldPropertyInfo.Single(m => m.IsPrimaryKey).FieldName;
                    // Make sure we always retrieve the primaryKey
                    if (!listPropertyName.Any(p => p.ToLower() == primaryKey))
                    {
                        listPropertyName.Add(primaryKey);
                    }
                    listFieldPropertyInfo = listFieldPropertyInfo.Where(p => listPropertyName.Select(x => x.ToLower()).Contains(p.FieldName.ToLower())).ToList();
                }
                if (listFieldPropertyInfo.Count > 0)
                {
                    object value; Type type;
                    foreach (FieldPropertyItem item in listFieldPropertyInfo)
                    {
                        try
                        {
                            // Retrieve property value/type
                            value = row[item.FieldName];
                            type = Nullable.GetUnderlyingType(item.PropertyDescriptor.PropertyType);
                            if (type == null)
                            {
                                type = item.PropertyDescriptor.PropertyType;
                            }

                            // Set the item's property value
                            item.PropertyDescriptor.SetValue(t, (value != null ? Convert.ChangeType(value, type) : value));
                        }
                        catch { }
                    }
                }
            }
            catch { }
        }
    }
}