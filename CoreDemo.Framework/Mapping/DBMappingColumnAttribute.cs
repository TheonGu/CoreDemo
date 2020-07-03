using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDemo.Framework.Mapping
{
    public class DBMappingColumnAttribute:DBMappingAttribute
    {
        public DBMappingColumnAttribute(string columnName):base(columnName)
        {
            
        }
    }
}
