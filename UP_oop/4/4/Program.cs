using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        for (int i = 0; i >= 0; i++)
        {
            Console.Write("Выберите пункт:\n"
                        + "1 - Перевести число.\n"
                        + "2 - Выйти из системы: ");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.Write("Введите значение для перевода от 1 до 2999: ");
                    int nums = int.Parse(Console.ReadLine());

                    if (nums == 0)
                    {
                        Console.WriteLine("Выбранное число не подходит под условие");
                    }

                    if (nums > 0 || nums <= 2999)
                    {
                        Console.WriteLine("Ваше число: " + Transfer(nums));
                    }
                    break;
                case 2:
                    return;
                    break;
                default:
                    Console.WriteLine("Данного варианта не имеется xD");
                    break;
            }
        }
    }
    public static string Transfer(int number)
    {
        int[] values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] numerals = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };


        StringBuilder result = new StringBuilder();


        for (int i = 0; i < 13; i++)
        {
            while (number >= values[i])
            {
                number -= values[i];
                result.Append(numerals[i]);
            }
        }
        return result.ToString();
    }
}