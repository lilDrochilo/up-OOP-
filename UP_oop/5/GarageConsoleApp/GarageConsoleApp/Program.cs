using System;

namespace GarageConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            
            for (int i = 0; i >= 0; i++)
            {
                Console.WriteLine("Выберите пункт:\n" +
                                  "1.Получить данные о водителях и их правах:\n" +
                                  "2.Добавить данные о водителе и его правах:\n" +
                                  "3.Получить данные о типах автомобилей\n" +
                                  "4.Добавить тип автомобиля\n" +
                                  "5.Просмотр машин\n" +
                                  "6.Добавление машины\n" +
                                  "7.Просмотр маршрутов\n" +
                                  "8.Добавление маршрутов\n" +
                                  "9.Просмотр рейсов\n" +
                                  "10.Добавление рейсов\n" +
                                  "0.Выход");
                int choise = Int32.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        DatabaseRequests.GetDriverQuery();
                        Console.WriteLine();
                        Console.Write("Введите id водителя, чьи права вы хотите увидеть:");
                        int numberDriver = Int32.Parse(Console.ReadLine());
                        DatabaseRequests.GetDriverRightsCategoryQuery(numberDriver);
                        break;
                    
                    case 2:
                        Console.Write("Имя: ");
                        string fName = Console.ReadLine();

                        Console.Write("Фамилия: ");
                        string SecondName = Console.ReadLine();

                        Console.Write("Дата рождения: ");
                        string bdate = Console.ReadLine();
                        DatabaseRequests.AddDriverQuery(fName,SecondName, bdate);
                        DatabaseRequests.GetDriverQuery();

                        for (int g = 0; g >= 0; g++)
                        {
                            Console.Write("Добавть категорию прав(Да или Нет): ");
                            string k = Console.ReadLine();
                            Console.WriteLine("");

                            if (k == "Нет" || k == "нет") break;

                            switch (k)
                            {
                                case "Да":
                                    Console.Write("Введите категорию прав (1 - А, 2 - В, 3 - D: ");
                                    int p = int.Parse(Console.ReadLine());
                                    Console.WriteLine("");

                                    Console.Write("Введите Id водителя, которому присвоить категорию прав: ");
                                    int l = int.Parse(Console.ReadLine());
                                    DatabaseRequests.AddDriverRightsCategoryQuery(l, p);
                                    Console.WriteLine("");
                                    break;

                                default:
                                    Console.Write("Данного вариант нет \n");
                                    break;
                            }
                            DatabaseRequests.SaveDriverQuery();
                        }
                        break;

                    case 3:
                        DatabaseRequests.GetTypeCarQuery();
                        Console.WriteLine();
                        break;
                    
                    case 4:
                        Console.WriteLine("Введите тип машины:");
                        string CarType = Console.ReadLine();
                        DatabaseRequests.AddTypeCarQuery(CarType);
                        DatabaseRequests.SaveCarQuery();
                        break;  
                    
                    case 5:
                        DatabaseRequests.CheckCar();
                        break;
                    
                    case 6:
                        Console.Write("Выберите тип авто:\n" +
                                          "1.Автобус\n" +
                                          "2.Микроавтобус\n" +
                                          "3.Легковой");
                        int Type = int.Parse(Console.ReadLine());
                        
                        Console.Write("Введите название авто:");
                        string nameCar = Console.ReadLine();
                        
                        Console.Write("Введите номера авто:");
                        string NumbersCar = Console.ReadLine();
                        
                        Console.WriteLine("Введите кол-во пассажиров");
                        int passangers = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Введите id машины:");
                        int id = int.Parse(Console.ReadLine());
                        
                        DatabaseRequests.AddCar(id_type_car:Type, name:nameCar, state_number:NumbersCar, passangers:passangers);
                        DatabaseRequests.SaveCar();
                        
                        break;  

                    
                    case 7:
                        DatabaseRequests.CheckItinerary();
                        break;
                    
                    case 8:
                        Console.WriteLine("Введите название маршрута, которого хотите добавить:");
                        string itinerary = Console.ReadLine();
                        DatabaseRequests.addItinerarry(name:itinerary);
                        DatabaseRequests.SaveItinerary();
                        break;
                    
                    case 9:
                        DatabaseRequests.checkRoute();
                        break;
                    
                    case 10:
                        DatabaseRequests.GetDriverQuery();
                        Console.WriteLine();
                        Console.WriteLine("Введите id водителя:");
                        int driv = int.Parse(Console.ReadLine());
                        
                        DatabaseRequests.CheckCar();
                        Console.WriteLine("Введите id авто:");
                        int carid = int.Parse(Console.ReadLine());
                        
                        DatabaseRequests.CheckItinerary();
                        Console.WriteLine("Введите id маршрута:");
                        int itineraryid = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Введите кол-во пассажиров:");
                        int pass = int.Parse(Console.ReadLine());
                        DatabaseRequests.addRoute(drivId:driv, carId:carid,itineraryid,passangerNum:pass);
                        DatabaseRequests.SaveRoute();
                        break;
                    
                    case 0:
                        return;
                }
            }
  
        }
    }
}