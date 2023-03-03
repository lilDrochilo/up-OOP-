using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using static System.Net.WebRequestMethods;

namespace api
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите название города:");
            string city = Console.ReadLine();
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid=5f1c5cc9819073d4bea9961aa919a3bc";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }

            Weather weather = JsonConvert.DeserializeObject<Weather>(response);
            Console.WriteLine("Температура: {0}: {1} C", weather.Name, weather.Main.Temp);

            string path = "Weather.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                if (path.Contains(city) == false)
                {
                    writer.WriteLine(" ");
                    writer.WriteLine("Город: {0}", weather.Name);
                    writer.Write("Температура: {0} C\n", weather.Main.Temp);

                }



            }
        }
    }
}

