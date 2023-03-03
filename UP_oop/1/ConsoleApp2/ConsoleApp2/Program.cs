using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.String;


namespace ConsoleApp2
{
    internal class Program
    {
        // task 1 
        //static void Main()
        //{
        //    Console.Write("Введите значение в строку S:");
        //    String s = Console.ReadLine();
        //    Console.Write("Введите значение в строку J:");
        //    String j = Console.ReadLine();
        //    int result = 0;

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        for (int h = 0; h < j.Length; h++)
        //        {
        //            if (s[i] == j[h])
        //            {
        //                result++;
        //            }
        //        }
        //    }
        //    Console.WriteLine(result);
        //}



        //task 3 
        static void Main() 
        {
            bool t= false;
            
            int[] nums = { 1, 2, 3, 4, 5, 6, 7};
            Array.Sort(nums);

            foreach (int i in nums)
            {
                if (nums[i-1] == nums[i]) { t = true; break; }
                else { t=false; break; }
            }
            Console.WriteLine(t);
            Console.ReadKey();
        }

    }
}
