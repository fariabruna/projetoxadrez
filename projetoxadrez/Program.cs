﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoxadrez
{
    class Program
    {
        static void Main(string[] args){

            Console.Write("Digite uma valor inteiro: ");

            int x = int.Parse(Console.ReadLine());

            int y = 3 * x;
            Console.WriteLine("Triplo = " + y);
            Console.ReadLine();
        }
    }
}
