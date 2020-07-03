using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CoreDemo.Framework.Mapping
{
    public static class DBMappingExtend
    {
        public static string GetMappingName<T>(this T t) where T : MemberInfo
        {
            if (t.IsDefined(typeof(DBMappingAttribute), true))
            {
                var attribute = t.GetCustomAttribute<DBMappingAttribute>();
                return attribute.GetMappingName();
            }
            return t.Name;
        }
        public static string GetMappingTableName<T>(this T t) where T : MemberInfo
        {
            if (t.IsDefined(typeof(DBMappingTableAttribute), true))
            {
                var attribute = t.GetCustomAttribute<DBMappingTableAttribute>();
                return attribute.GetMappingName();
            }
            return t.Name;
        }
        public static string GetMappingColumnName<T>(this T t) where T : MemberInfo
        {
            if (t.IsDefined(typeof(DBMappingColumnAttribute), true))
            {
                var attribute = t.GetCustomAttribute<DBMappingColumnAttribute>();
                return attribute.GetMappingName();
            }
            return t.Name;
        }
    }
}
