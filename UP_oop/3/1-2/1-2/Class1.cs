using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WORKER
{
    public class Worker
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int rate { get; set; }
        public int days { get; set; }

        public Worker()
        {
            name = "Tim";
            surname = "Mix";
            rate = 7;
            days = 1;
        }

        public void GetSalary()
        {
            Console.WriteLine($"Зарплата: {rate * days}\n");
        }
        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}\n" +
                              $"Фамилия: {surname}\n" +
                              $"Ставка за день работы: {rate}\n" +
                              $"Отработанные дни: {days}\n");
        }
    }
}