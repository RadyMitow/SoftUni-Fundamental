using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Vehicle_catalog
{
    class VehicleCatalog
    {
        static void Main(string[] args)
        {
            Vehicle vehicle;
            List<Vehicle> Catalog = new List<Vehicle>();
            string vehicleInfoCommand = Console.ReadLine();
            while (vehicleInfoCommand != "End")
            {
                string[] vehicleInfo = vehicleInfoCommand.Split().ToArray();
                string vehicleType = vehicleInfo[0].Substring(0, 1).ToUpper() + vehicleInfo[0].Substring(1);
                vehicle = new Vehicle(vehicleType, vehicleInfo[1], vehicleInfo[2], int.Parse(vehicleInfo[3]));
                Catalog.Add(vehicle);
                vehicleInfoCommand = Console.ReadLine();

            }

            string printComand =Console.ReadLine();
            while (printComand != "Close the Catalogue")
            {
                PrintVehicle(printComand);
                printComand = Console.ReadLine();

            }

            CalculateAverageHP("Car");
            CalculateAverageHP("Truck");

            void PrintVehicle(string vehicleModel)
            {
                foreach (var item in Catalog.Where(x => x.Model == vehicleModel))
                {
                    Console.WriteLine(item);
                }
            }


             void CalculateAverageHP(string vehicleType)
            {
                int vehiclesNumber = 0;
                double totalHP = 0;
                foreach (var item in Catalog.Where(x => x.Type== vehicleType))
                {
                    vehiclesNumber ++;
                    totalHP+= item.HP;
                }
                if (totalHP == 0)
                {
                    Console.WriteLine($"{vehicleType}s have average horsepower of: {totalHP:F2}.");
                }
                else
                {
                    Console.WriteLine($"{vehicleType}s have average horsepower of: {(totalHP / vehiclesNumber):F2}.");
                }
                
            }
        }
        
    }
    
    public class Vehicle
    {
        public Vehicle(string type, string model, string color, int hP)
        {
            Type = type;
            Model = model;
            Color = color;
            HP = hP;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HP { get; set; }

       
        public override string ToString()
        {
            string result = $"Type: { Type}\r\nModel: {Model}\r\nColor: {Color}\r\nHorsepower: {HP}";
            return result;
        }
    }
}
