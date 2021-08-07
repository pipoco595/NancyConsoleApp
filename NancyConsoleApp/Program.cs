using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Nancy;
using Nancy.Hosting.Self;


namespace NancyConsoleApp
{
    // a simple module to be hosted in the console app
    public class MainModule : NancyModule
    {
        public MainModule()
        {
            Get("/", x => { return "Hello World"; });
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // initialize an instance of NancyHost (found in the Nancy.Hosting.Self package)
            var host = new NancyHost(new Uri("http://localhost:12345"));
            host.Start(); // start hosting

            Console.ReadKey();
            host.Stop();  // stop hosting
        }
    }
}
