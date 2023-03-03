using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Xml.Linq;

namespace WORKER
{
    public class Program
    {
        static void Main()
        {
            var work = new Worker();

            for (int i = 0; i >= 0; i++)
            {
                Console.Write("Выберите пункт:\n"
                                + "1 - Посмотреть информацию.\n"
                                + "2 - Узнать з/п.\n"
                                + "3 - Изменить отработанные дни.\n"
                                + "4 - Изменить ставку за день работы.\n"
                                + "5 - Выйти из системы: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (a)
                {
                    case 1:
                        work.GetInfo();
                        break;
                    case 2:
                        work.GetSalary();
                        break;
                    case 3:
                        Console.Write("Введите количество дней: ");
                        work.days = int.Parse(Console.ReadLine());
                        work.GetInfo();
                        break;
                    case 4:
                        Console.Write("Введите ставку: ");
                        work.rate = int.Parse(Console.ReadLine());
                        work.GetInfo();
                        break;
                    case 5:
                        return;
                        break;
                    default:
                        Console.WriteLine("Данного варианта не имеется xD");
                        break;
                }
            }
        }
    }
}
