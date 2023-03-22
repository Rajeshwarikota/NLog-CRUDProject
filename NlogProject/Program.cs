using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("....NLog...");
            Adding.Sum(1,3);
            SwappingNumber.Swap();
            Console.ReadLine();
        }
    }
}

