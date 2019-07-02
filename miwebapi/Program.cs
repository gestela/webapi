using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace miwebapi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
    public class Person
    {
        public int edad { get; private set; }
        public int Promedio { get; private set; }
        public void Hello()
        {

            Console.WriteLine("hola");
        }

        public void SetAge(int n)
        {
            this.edad = n;

        }
        public void SetPromedio(int prom)
        {
            this.Promedio = prom;
        }

    }

    public class Student : Person
    {

        public void showage()
        {

            Console.WriteLine("edad:" + this.edad);
        }
    }

    public class Teacher : Person
    {
        public void explain()
        {
            Console.WriteLine("Explanation Begins");
        }

        private string subject { get; set; }
    }



}


