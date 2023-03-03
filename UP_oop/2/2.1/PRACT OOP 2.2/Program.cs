using OOPLYBR2._2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment.Internal;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PRACT_OOP_2._2
{
    public class Program
    {


        static void Main()
        {
            Student std= new Student();
            for (int i = 0; i >= 0; i++)
            {
                Console.WriteLine("Выберете пункт:\n" +
                 "1.Просмотр информации:\n" +
                 "2.Изменение данных:\n" +
                 "3.Выход.\n");


                int A = int.Parse(Console.ReadLine());
                switch (A)
                {
                    case 1:
                        std.StudentInfo();
                        break;
                    case 2:
                        Edit(std);
                        break;
                    case 3:
                        return;
                    case 4: return;

                }
            }
            


        }

        static public void Edit(Student stud)
        {
            for (int i = 0; i >= 0; i++)
            {
                Console.Write("Введите фамилию:");
                stud.secondName= Console.ReadLine();
                Console.Write("Введите дату рождения:");
                stud.dateOfBirthday = Console.ReadLine();
                Console.Write("Введите номер группы:");
                stud.numbersGroups = int.Parse(Console.ReadLine());

                stud.progress = new int[5];
                for (int j = 0; j < stud.progress.Length; j++)
                {
                    Console.Write("Введите оценку:");
                    stud.progress[j] = int.Parse(Console.ReadLine());
                }
                stud.StudentInfo();
                break;
            }
            


        }



    }
}
