﻿using NLog;
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
            Console.WriteLine("Enter the Option the below");
            Console.WriteLine("\n:Adding\n2:Swapping\n3:ListCRUD");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Adding.Sum(1, 3);
                    break;
                case 2:
                    SwappingNumber.Swap();
                    break;
                case 3:
                    ListCRUD.list();
                    break;
            }
            Console.ReadLine();
        }
    }
}


