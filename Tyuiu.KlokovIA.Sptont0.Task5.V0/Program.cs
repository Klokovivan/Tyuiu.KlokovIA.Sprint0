using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KlokovIA.Sprint0.Task5.V0.Lib;

namespace Tyuiu.KlokovIA.Sptont0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример линейной структуры
            Console.WriteLine(" A + B = " + DataService.Addition(1, 5));
            Console.WriteLine(" A - B = " + DataService.Subtraction(15, 5));
            Console.WriteLine(" A * B = " + DataService.Multiplication(10, 10));

            // Пример развитвляющейся структурынаходится в библиотеке классов Division
            Console.WriteLine(" A / B = " + DataService.Division(6, 2));
            Console.ReadKey();


        }
    }
}
