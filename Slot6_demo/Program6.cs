﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot6_demo
{
    class Program6
    {
        static void Main(string[] args)
        {
            string[] names = { "Hung", "Dat", "Manh", "Tri" };
            foreach (string name in names.OrderBy(s => s))
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
