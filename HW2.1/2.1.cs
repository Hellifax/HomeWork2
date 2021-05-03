using System;

namespace HW2._1
{
    class Program
    {       
        static void Main(string[] args)
        {
          Console.WriteLine("Введите номер текущего месяца:");
            var num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Текущий месяц: январь");
                    break;
                case 2:
                    Console.WriteLine("Текущий месяц: февраль");
                    break;
                case 3:
                    Console.WriteLine("Текущий месяц: март");
                    break;
                case 4:
                    Console.WriteLine("Текущий месяц: апрель");
                    break;
                case 5:
                    Console.WriteLine("Текущий месяц: май");
                    break;
                case 6:
                    Console.WriteLine("Текущий месяц: июнь");
                    break;
                case 7:
                    Console.WriteLine("Текущий месяц: июль");
                    break;
                case 8:
                    Console.WriteLine("Текущий месяц: август");
                    break;
                case 9:
                    Console.WriteLine("Текущий месяц: сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Текущий месяц: октябрь");
                    break;
                case 11:
                    Console.WriteLine("Текущий месяц: ноябрь");
                    break;
                case 12:
                    Console.WriteLine("Текущий месяц: декабрь");
                    break;

                    /*Console.WriteLine("Введите номер текущего месяца:");
                    var a = Console.ReadLine();
                    DateTime now = DateTime.Now;
                    Console.WriteLine(now.Month);
                    Console.WriteLine(now.ToString("MMM")); - второй вариант кода */


            }
        }
    }
}
