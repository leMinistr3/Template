using Hyper.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using Template.GSFTCore.Class;
using Template.GSFTCore.GSFTAttribute;

namespace Template.GSFTCore.Provider
{
    // Singleton approach - For more info see: http://csharpindepth.com/Articles/General/Singleton.aspx
    public sealed class FieldPropertyProvider
    {
        // Set up in order to make this class a lazy singleton class
        private static readonly Lazy<FieldPropertyProvider> _lazy = new Lazy<FieldPropertyProvider>(() => new FieldPropertyProvider());
        public static FieldPropertyProvider Instance { get { return _lazy.Value; } }
        private FieldPropertyProvider() { }

        // Private Fields
        private static Dictionary<string, List<FieldPropertyItem>> _dictionaryFieldPropertyItems = new Dictionary<string, List<FieldPropertyItem>>();


        /// <summary>
        /// Return a listing of "FieldPropertyItem" class
        /// </summary>
        /// <param name="objectType">The type of object where we are getting the property infos</param>
        /// <param name="contentType">The telerik model full name string</param>
        /// <returns></returns>
        public List<FieldPropertyItem> GetFieldPropertyListing(Type objectType, DataRow row)
        {
            List<FieldPropertyItem> listFieldPropertyItem = new List<FieldPropertyItem>();

            lock (_dictionaryFieldPropertyItems)
            {
                try
                {
                    // Create the key
                    string key = objectType.FullName + row.Table.TableName;

                    // Try to get the list of field property item - If key doesnt exist create the list and return it.
                    if (!_dictionaryFieldPropertyItems.TryGetValue(key, out listFieldPropertyItem))
                        listFieldPropertyItem = AddRetrieveDictionaryFieldPropertyItem(objectType, row);
                }
                catch { }

                return listFieldPropertyItem;
            }
        }


        /// <summary>
        /// Add a new dictionary item to the dictionary field property items then return the item
        /// </summary>
        /// <param name="objectType">The type of object where we are getting the property infos</param>
        /// <param name="contentType">The resolve type of a telerik model full name string</param>
        private List<FieldPropertyItem> AddRetrieveDictionaryFieldPropertyItem(Type objectType, DataRow row)
        {
            // Variable scope declarations
            List<FieldPropertyItem> listFieldPropertyItem = new List<FieldPropertyItem>();

            try
            {
                // Append to the hyper property descriptor the current object type
                HyperTypeDescriptionProvider.Add(objectType);

                // Retrieve all property descriptor of the current object type
                PropertyDescriptorCollection listPropertyDescriptors = TypeDescriptor.GetProperties(objectType);

                // Retrieve all the fields associated to the contentType parameter then create a list of string. Keep in mind the following fields are not added "Id", "DateCreated", "LastModified" so we will be adding them by default
                List<string> listFieldName = new List<string>();
                foreach (DataColumn column in row.Table.Columns)
                {
                    listFieldName.Add(column.ColumnName);
                }

                // Variable scope declarations
                FieldPropertyItem fieldPropertyItem; 
                PropertyDescriptor propertyDescriptor;
                foreach (string fieldName in listFieldName)
                {
                    try
                    {
                        // Retrieve a property descriptor from out collection base on the current field name
                        propertyDescriptor = listPropertyDescriptors[fieldName];
                        if (propertyDescriptor != null)
                        {
                            // Create out field property item
                            fieldPropertyItem = new FieldPropertyItem();
                            fieldPropertyItem.PropertyDescriptor = propertyDescriptor;
                            fieldPropertyItem.FieldName = fieldName;
                            fieldPropertyItem.IsPrimaryKey = propertyDescriptor.Attributes.OfType<PrimaryKey>().Any();

                            // Add instance to the list
                            listFieldPropertyItem.Add(fieldPropertyItem);
                        }
                    }
                    catch { }
                }

                // Make sure we actually generated a list of field property items - Append to the dictionary
                if (listFieldPropertyItem.Count > 0)
                    _dictionaryFieldPropertyItems.Add(objectType.FullName + row.Table.TableName, listFieldPropertyItem);
            }
            catch { }

            return listFieldPropertyItem;
        }
    }
}