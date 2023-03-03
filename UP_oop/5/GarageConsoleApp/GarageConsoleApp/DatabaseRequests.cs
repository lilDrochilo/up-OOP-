using System;
using Npgsql;

namespace GarageConsoleApp
{
    public static class DatabaseRequests
    {

        public static void GetTypeCarQuery()
        {

            var querySql = "SELECT * FROM type_car";

            using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());

            using var reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                Console.WriteLine($"Id: {reader[0]} Название: {reader[1]}");
            }
        }


        public static void AddTypeCarQuery(string name)
        {
            var querySql = $"INSERT INTO type_car(name) VALUES ('{name}')";
            using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
            cmd.ExecuteNonQuery();
        }

        public static void SaveCarQuery()
        {
            string path = "TypeCar1.txt";
            var querySql = "SELECT * FROM type_car";
            using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
            using var reader = cmd.ExecuteReader();
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                while (reader.Read())
                {
                    writer.WriteLine($"Id:{reader[0]};\n Название:{reader[1]}\n");
                }
            }

        }


        public static void AddDriverQuery(string firstName, string lastName, string birthdate)
        {
            var querySql =
                $"INSERT INTO driver(first_name, last_name, birthdate) VALUES ('{firstName}', '{lastName}', '{birthdate}')";
            using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
            cmd.ExecuteNonQuery();
        }

        public static void SaveDriverQuery()
        {
            string path = "DriverQuery.txt";
            var querySql = "SELECT * FROM driver ";
            using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
            using var reader = cmd.ExecuteReader();
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                while (reader.Read())
                {
                    writer.WriteLine(
                        $"Id:{reader[0]};\n FirstName:{reader[1]}\n, Lastname:{reader[2]},birthDay:{reader[3]}");
                }
            }

        }


        public static void GetDriverQuery()
        {
            var querySql = "SELECT * FROM driver";
            using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"Id: {reader[0]} Имя: {reader[1]} Фамилия: {reader[2]} Дата рождения: {reader[3]}");
            }
        }


        public static void AddRightsCategoryQuery(string name)
        {
            var querySql = $"INSERT INTO rights_category(name) VALUES ('{name}')";
            using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
            cmd.ExecuteNonQuery();
        }

        public static void SaveRightQuery()
        {
            string path = "TypeCar1.txt";
            var querySql = "SELECT * FROM rights_category";
            using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
            using var reader = cmd.ExecuteReader();
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                while (reader.Read())
                {
                    writer.WriteLine($"Id:{reader[0]};\n name:{reader[1]}\n");
                }
            }

        }


        public static void AddDriverRightsCategoryQuery(int driver, int rightsCategory)
        {
            var querySql =
                $"INSERT INTO driver_rights_category(id_driver, id_rights_category) VALUES ({driver}, {rightsCategory})";
            using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
            cmd.ExecuteNonQuery();
        }

        public static void GetDriverRightsCategoryQuery(int driver)
        {
            var querySql = "SELECT dr.first_name, dr.last_name, rc.name " +
                           "FROM driver_rights_category " +
                           "INNER JOIN driver dr on driver_rights_category.id_driver = dr.id " +
                           "INNER JOIN rights_category rc on rc.id = driver_rights_category.id_rights_category " +
                           $"WHERE dr.id = {driver};";
            using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"Имя: {reader[0]} Фамилия: {reader[1]} Категория прав: {reader[2]}");
            }
        }

        public static void CheckCar()
        {
            var carSql = "SELECT * FROM car";
            using var cmd = new NpgsqlCommand(carSql, DatabaseService.GetSqlConnection());
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"id: {reader[0]}\n Марка авто: {reader[2]} ");
            }
        }

        public static void AddCar(string name, int id_type_car, string state_number, int passangers)
        {
            var querySql =
                $"INSERT INTO car(id, id_type_car, name,state_number,number_passengers) VALUES ({id_type_car}, '{name}', '{state_number}',{passangers})";
            using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
            cmd.ExecuteNonQuery();
        }

        public static void SaveCar()
        {
            string path = "TypeCar1.txt";
            var querySql = "SELECT * FROM car";
            using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
            using var reader = cmd.ExecuteReader();
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                while (reader.Read())
                {
                    writer.WriteLine(
                        $"Id:{reader[0]};\n Name:{reader[1]}\n, id type car:{reader[2]}\n, state number:{reader[3]}\n, passangers:{reader[4]}\n");
                }
            }

        }

        public static void CheckItinerary()
        {
            var carSql = "SELECT * FROM itinerary";
            using var cmd = new NpgsqlCommand(carSql, DatabaseService.GetSqlConnection());
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"id: {reader[0]}\n Маршрут: {reader[1]} ");
            }
        }

        public static void addItinerarry(string name)
        {
            var querySql =
                $"INSERT INTO itinerrary(name) VALUES ('{name}')";
            using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
            cmd.ExecuteNonQuery();
        }

        public static void SaveItinerary()
        {
            string path = "TypeCar1.txt";
            var querySql = "SELECT * FROM itinerary";
            using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
            using var reader = cmd.ExecuteReader();
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                while (reader.Read())
                {
                    writer.WriteLine($"Id:{reader[0]};\n Название:{reader[1]}\n");
                }
            }

        }

        public static void checkRoute()
        {
            var carSql = "SELECT * FROM route";
            using var cmd = new NpgsqlCommand(carSql, DatabaseService.GetSqlConnection());
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(
                    $"id: {reader[0]}\n ID Водителя: {reader[1]}\n ID Авто: {reader[2]}\n ID Маршрута: {reader[1]}\n");
            }
        }

        public static void addRoute(int drivId, int carId, int ItineraryId, int passangerNum)
        {
            var querySql =
                $"INSERT INTO route(id_driver,id_car,id_itinerary,number_passengers) VALUES ({drivId},{carId},{ItineraryId},{passangerNum})";
            using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
            cmd.ExecuteNonQuery();
        }

        public static void SaveRoute()
        {
            string path = "TypeCar1.txt";
            var querySql = "SELECT * FROM route";
            using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
            using var reader = cmd.ExecuteReader();
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                while (reader.Read())
                {
                    writer.WriteLine(
                        $"Id:{reader[0]};\n Driver id:{reader[1]}\n , carId{reader[2]}\n, itineraryId{reader[3]}\n,passangers{reader[4]}\n");
                }
            }

        }
    }
}