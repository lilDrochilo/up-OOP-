using System;
using System.Diagnostics;

using System.Globalization;
using System.Xml.Linq;


namespace oop_2._4
{
    public class Program
    {
        static void Main()
        {
            var sub = new reduce();

            for (int i = 0; i >= 0; i++)
            {
                Console.Write("Выберите нужный пункт:\n"
                            + "1.Посмотреть счетчик.\n"
                            + "2.Уменьшить.\n"
                            + "3.Увеличить.\n"
                            + "4.Выйти из системы: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (a)
                {
                    case 1:
                        sub.CounterInfo();
                        break;
                    case 2:
                        Reduce(sub);
                        sub.CounterInfo();
                        break;
                    case 3:
                        Add(sub);
                        sub.CounterInfo();
                        break;
                    case 4:
                        return;
                        break;
                }
            }
        }

        static void Reduce(reduce sub)
        {
            sub.counter--;
        }

        static void Add(reduce sub)
        {
            sub.counter++;
        }
    }
}