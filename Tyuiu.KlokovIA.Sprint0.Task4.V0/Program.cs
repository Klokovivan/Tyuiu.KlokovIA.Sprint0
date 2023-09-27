﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KlokovIA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.KlokovIA.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример линейной структуры
            // Вызов метода сложения Addition
            Console.WriteLine(DataService.Addition(1, 5));

            // Вызов метода вычитания Subtraction
            Console.WriteLine(DataService.Subtraction(15, 5));

            // Вызов метода умножения Multiplication
            Console.WriteLine(DataService.Multiplication(10, 10));

            // Вызов метода деления Division
            Console.WriteLine(DataService.Division(12, 2));

            Console.ReadKey();
        }
    }
}
