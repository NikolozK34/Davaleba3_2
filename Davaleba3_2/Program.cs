﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davaleba3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sheuyvane ricxvi: ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(n * i);
            }
        }
    }
}
