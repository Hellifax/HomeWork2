using System;

namespace HW2._4
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Введите число месяца:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите среднюю температуру:");
            var temp = Convert.ToDouble(Console.ReadLine());
            if (a == 1 || a == 2 || a == 12 && temp > 0)
            {
                Console.WriteLine("Дождливая зима!");
            }
            else
            {
                Console.WriteLine("Погода не предсказуема!");
            }

        }
    }
}
