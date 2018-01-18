using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskThree
{
    class Program
    {
        static double ReadDouble() //Ввод действительного числа
        {
            double num = 0;
            bool OK = false;
            do
            {
                try
                {
                    num = Convert.ToDouble(Console.ReadLine());
                    OK = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка ввода. Ожидалось число.");
                    OK = false;
                }
            } while (!OK);
            return num;
        }

        static void Main(string[] args)
        {
            double x, y;
            bool answer = false;
            Console.WriteLine("Введите x:");
            x = ReadDouble();
            Console.WriteLine("Введите y:"); 
            y = ReadDouble();
            answer = (y >= Math.Abs(x)) || (y >= 1);
            if (answer) Console.WriteLine("Точка принадлежит заданной области.");
            else Console.WriteLine("Точка не принадлежит заданной области.");

            Console.ReadLine();
        }
    }
}
