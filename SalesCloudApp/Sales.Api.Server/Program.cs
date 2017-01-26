using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Api.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:9000/";

            App_Start.Startup.LoadWebConfig();
            WebApp.Start<App_Start.Startup>(url: baseAddress);

            Console.Read();
        }
    }
}
