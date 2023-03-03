using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2._2._3
{
    public class Program
    {
        static void Main()
        {
            
            List<Train> t = new List<Train>()
            {
                new Train(1,"Киров","22:21"),
                new Train(2,"Томск 1","12:00"),
                new Train(3,"Новосибирск","16:40"),
            };
            Console.WriteLine( "Введите номер поезда:" );
            int trainNum = Convert.ToInt32( Console.ReadLine() );
            foreach (Train train in t)
            {
                if (train.trainNumber==trainNum)
                {
                    train.TrainInfo();
                    
                }
            }


            
        }
    }
}
