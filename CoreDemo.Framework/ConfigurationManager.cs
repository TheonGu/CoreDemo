using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CoreDemo.Framework
{
    public class ConfigurationManager
    {
        static ConfigurationManager()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            IConfigurationRoot configuration = builder.Build();
            _SqlConnectionStringCustom=configuration.GetConnectionString("Customers");
            //_SqlConnectionStringCustom = configuration["ConnectionStrings:Customers"];
        }
        private static string _SqlConnectionStringCustom = null;
        public static string SqlConnectionStringCustom
        {
            get
            {
                return _SqlConnectionStringCustom;
            }
        }
    }
}
