using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDemo.Framework.Mapping
{
    public class DBMappingAttribute:Attribute
    {
        private string _MappingName = null;
        public DBMappingAttribute(string name)
        {
            this._MappingName = name;
        }
        public string GetMappingName()
        {
            return this._MappingName;
        }
    }
}
