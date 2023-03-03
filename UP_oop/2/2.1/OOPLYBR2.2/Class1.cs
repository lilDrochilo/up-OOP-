using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPLYBR2._2
{
    public class Student
    {

        //private string secondName = "Михалев" ;
        //private string dateOfBirthday = "04.09.2004";
        //private int numbersGroups=623;
        //private int[] progress= new int[] {2,4,5,3,5 };

        public string secondName { get; set; }
        public string dateOfBirthday { get; set; }

        public int numbersGroups { get; set; }

        public int[] progress { get; set; }

        //public Student()
        //{
        //    this.secondName = "nonename";
        //    this.dateOfBirthday = "01.01.2023";
        //    this.numbersGroups = 0;
        //    this.progress = new int[] { 0, 0, 0, 0, 0 };
        //}

        //public Student(string secondName, string dateOfBirthday, int numbersGroups, int[] progress)
        //{
        //    this.secondName = secondName;
        //    this.dateOfBirthday = dateOfBirthday;
        //    this.numbersGroups = numbersGroups;
        //    this.progress = progress;
        //}
        //public void Edit(string name, string date, int gr, int[] progress)
        //{
        //    this.secondName = name;
        //    this.dateOfBirthday = date;
        //    this.numbersGroups = gr;
        //    this.progress = progress;



        //}


        public void StudentInfo()
        {
            Console.WriteLine($"Second name: {secondName} \n" +
                              $"Date of birthday: {dateOfBirthday} \n" +
                              $"Numbers group: {numbersGroups} \n");

            Console.WriteLine("Успеваемость:");
            foreach (int i in progress)
            {
                Console.Write(progress[i] + " ");
            }
            Console.WriteLine();
        }

    }





}
