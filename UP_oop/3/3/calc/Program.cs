using calc.PRACT;
using System;

namespace PRACT
{
    public class Program
    {
        static void Main()
        {
            var calc = new Calculation();

            for (int i = 0; i >= 0; i++)
            {
                Console.Write("Выберите пункт:\n"
                                + "1 - Посмотреть информацию.\n"
                                + "2 - Изменить свойство.\n"
                                + "3 - Добавить символ в конец.\n"
                                + "4 - Вывести последний символ.\n"
                                + "5 - Удалить последний символ. \n"
                                + "6 - Выйти из системы: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (a)
                {
                    case 1:
                        calc.GetCalculationLine();
                        break;
                    case 2:
                        calc.SetCalculationLine();
                        break;
                    case 3:
                        calc.SetLastSymbolCalculationLine();
                        break;
                    case 4:
                        calc.GetLastSymbol();
                        break;
                    case 5:
                        calc.DeleteLastSymbol();
                        calc.GetCalculationLine();
                        break;
                    case 6:
                        return;
                        break;
                    default:
                        
                }
            }
        }
    }
}