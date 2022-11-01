using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Vehicles

            List<Vehicle> vehicles = new List<Vehicle>();

            Vehicle car1 = new Car() { Year = "1966", Make = "Lamborghini", Model = "Miura", NumberOfTires = 4, NumberOfWindows = 3 };
            Car car2 = new Car() { Year = "1969", Make = "Dodge", Model = "Charger", NumberOfTires = 4, NumberOfWindows = 4 };
            Motorcycle motor1 = new Motorcycle() { Year = "2023", Make = "ARCH", Model = "1s", EngineNoise = "Vrrrrooooom" };
            Vehicle motor2 = new Motorcycle(); 

            vehicles.Add(car1);
            vehicles.Add(car2);
            vehicles.Add(motor1);
            vehicles.Add(motor2);

            foreach (var item in vehicles)
            {
                Console.WriteLine($"{item.Year} {item.Make} {item.Model}");
                Console.WriteLine();
            }

           
            car1.DriveAbstract();
            Console.WriteLine();
            car1.DriveVirtual();
            Console.WriteLine();
            motor1.DriveAbstract();
            Console.WriteLine();
            motor1.DriveVirtual();

            #endregion

            Console.ReadLine();
        }
    }
}
