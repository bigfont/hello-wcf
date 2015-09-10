using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClient.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new ServiceReference1.Service1Client();
            var result = client.GetData(5);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
