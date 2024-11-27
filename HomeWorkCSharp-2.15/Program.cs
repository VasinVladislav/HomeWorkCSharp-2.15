using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp_2._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.15. Даны два числа. Найти их сумму, разность, произведение, а также частное от деления первого числа на второе.
            Console.WriteLine("Программа для вычисления суммы, разности, произведения, частного от деления двух чисел.");
            Console.Write("Введите первое число: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double sum = x + y;
            double raz = x - y;
            double pro = x * y;
            double chas = x / y;
            Console.WriteLine($"Сумма {x} и {y} равна {sum}\nРазность {x} и {y} равна {raz}\nПроизведение {x} и {y} равно {pro}\nЧастное от деления {x} на {y} равно {chas}");
        }
    }
}
