
namespace calc
{
    using Microsoft.VisualBasic;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using static System.Runtime.InteropServices.JavaScript.JSType;
    using Microsoft.VisualBasic;

    namespace PRACT
    {
        public class Calculation                
        {
            public string calculationLine { get; set; }

            public Calculation()
            {
                calculationLine = "DEFAULT";
            }


            public void SetCalculationLine()
            {
                //ИЗМЕНЕНИЕ ЗНАЧЕНИЯ СВОЙСТВА 
                Console.Write("Введите значение в строку: ");
                calculationLine = Console.ReadLine();
                Console.WriteLine("");
            }

            public void SetLastSymbolCalculationLine()
            {
                //ПРИБАВЛЕНИЕ СИМВОЛА В КОНЕЦ 
                Console.Write("Введите сивол, который " +
                    "хотите ввести в конец строки: ");
                string s = Console.ReadLine();
                calculationLine += s;
                Console.WriteLine("");
            }

            public void GetCalculationLine()
            {
                //ВЫВОД ЗНАЧЕНИЯ СВОЙСТВА 
                Console.WriteLine("Ваша строка: " + calculationLine + "\n");
            }

            public void GetLastSymbol()
            {
                //ВЫВОД ПОСЛЕДНЕГО СИМВОЛА 
                Console.WriteLine("Последний символ строки: " + Strings.Right(calculationLine, 1) + "\n");
            }

            public void DeleteLastSymbol()
            {
                //удаление ласт символа 
                calculationLine = calculationLine.Remove(calculationLine.Length - 1, 1);
                Console.WriteLine("Последний символ удален.");
            }

        }
    }
}