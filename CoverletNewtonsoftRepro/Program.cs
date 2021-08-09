using System;
using Newtonsoft.Json;

namespace CoverletNewtonsoftRepro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(JsonConvert.SerializeObject(new { prop = "value" }));
        }
    }
}