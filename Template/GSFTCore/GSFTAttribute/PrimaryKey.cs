using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Template.GSFTCore.GSFTAttribute
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class PrimaryKey : Attribute
    {
    }
}