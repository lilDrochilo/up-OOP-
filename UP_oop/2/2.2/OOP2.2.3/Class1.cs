using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2._2._3
{
    public class Train
    {
        public int trainNumber { get; set; }
        public string timeStart { get; set; }
        public string destination { get; set; }

       public Train(int trainNumber, string timeStart, string destination)
        {
            this.trainNumber = trainNumber;
            this.destination = destination;
            this.timeStart = timeStart;
        }

         public void TrainInfo()
        {
            Console.Write($"Пункт отправления: " +
                $"{destination}\n" +
                $"Номер поезда: {trainNumber}\n" + $"Время отправления:{timeStart}\n");
        }


        
    }
}

    


