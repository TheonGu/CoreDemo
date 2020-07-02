using CoreDemo.Framework;
using System;
using System.Configuration;

namespace CoreDemo.Cos
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = ConfigurationManager.SqlConnectionStringCustom;
            Console.WriteLine(s);
        }
    }
}
