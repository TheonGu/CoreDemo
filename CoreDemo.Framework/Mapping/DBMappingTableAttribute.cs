using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDemo.Framework.Mapping
{
    public class DBMappingTableAttribute:DBMappingAttribute
    {
        public DBMappingTableAttribute(string tableName):base(tableName)
        {
            
        }
    }
}
