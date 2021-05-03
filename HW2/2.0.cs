using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальную температура за сегодняшний день:");// Предполагается что будут использованы целые числа. Температура обычно указывается без дробной части.
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите минимальную температура за сегодняшний день:");
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToDouble(a + b) / 2;// для более точного выведения результата
            Console.WriteLine("Среднесуточная температура: {0}", c);
        }
    }
}
