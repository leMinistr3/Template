using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace Template.GSFTCore.Provider
{
    /// <summary>
    /// Provide based core model base processes - contains a listing of property names that had their property value modify
    /// </summary>
    public class CoreModelProvider : INotifyPropertyChanged
    {
        // Private, public properties/fields
        public event PropertyChangedEventHandler PropertyChanged;
        public List<string> ListPropertyName;


        // Constructor
        public CoreModelProvider()
        {
            ListPropertyName = new List<string>();
        }


        /// <summary>
        /// Determine wether the value have changed, if so append the property name in the list of property name field
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="storage"></param>
        /// <param name="value"></param>
        /// <param name="propertyName"></param>
        protected void SetProperty<T>(ref T storage, T value, [CallerMemberName] String propertyName = null)
        {
            // if (!object.Equals(storage, value))
            if (!EqualityComparer<T>.Default.Equals(storage, value))
            {
                storage = value;
                if (!ListPropertyName.Any(x => x == propertyName))
                    ListPropertyName.Add(propertyName);
                this.OnPropertyChanged(propertyName);
            }
        }


        /// <summary>
        /// Attach a property change event on the supplied property name
        /// </summary>
        /// <param name="propertyName"></param>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var eventHandler = this.PropertyChanged;
            if (eventHandler != null)
            {
                eventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}