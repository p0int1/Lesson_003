using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car { X = 10, Y = 10, Price = 22000, Speed = 100, Year = 1995 };
            Console.WriteLine("Цена автомобиля {0}$, скорость {1} км/ч, год выпуска {2}", car.Price, car.Speed, car.Year);

            Ship ship = new Ship { X = 33, Y = 12, Price = 600000, Speed = 30, Year = 1958, NumPassengers = 74, Port = "Шанхай" };
            Console.WriteLine("Цена корабля {0}$, скорость {1} узлов, год выпуска {2}, количество пассажиров {3}, базовый порт {4}", ship.Price, ship.Speed, ship.Year, ship.NumPassengers, ship.Port);

            Planer planer = new Planer { X = 76, Y = 37, Price = 74000000, Speed = 950, Year = 1988, NumPassengers = 120, FlightAltitude = 11000 };
            Console.WriteLine("Цена самолета {0}$, скорость {1} км/ч, год выпуска {2}, количество пассажиров {3}, высота полета {4}", planer.Price, planer.Speed, planer.Year, planer.NumPassengers, planer.FlightAltitude);
            
            Console.ReadKey();
        }
    }
}
