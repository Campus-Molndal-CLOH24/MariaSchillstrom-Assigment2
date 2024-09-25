using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MariaSchillstrom_Assigment2.Interfaces;
using MariaSchillstrom_Assignment_2.InterFaces;



namespace MariaSchillstrom_Assignment_2.Models
{
    public class CarImpl : ICar
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }
        public string EngineType { get; set; }
        public int Doors { get; set; }
        public double mileage { get; set; }

        private bool engineOn = false;

        public class Car
        {
            private int doors;

            public int Doors
            {
                get => doors;
                set
                {
                    
                    if (value >= 2 && value <= 5)
                    {
                        doors = value;  
                    }
                    else
                    {
                        Console.WriteLine("Antalet dörrar måste vara mellan 2 och 5.");
                    }
                }
            }
        }



        public CarImpl(string brand, string model, int year, double mileage, string engineType, int doors)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Mileage = mileage;
            EngineType = engineType;
            Doors = doors;
        }

        
        public bool IsEngineOn()
        {
            return engineOn;
        }

        public void StartEngine()
        {
            if (!engineOn)
            {
                engineOn = true;
                Console.WriteLine("The engine started!");
            }
        }

        public void StopEngine()
        {
            if (engineOn)
            {
                engineOn = false;
                Console.WriteLine("The engine stopped.");
            }
        }

        public string Drive()
        {
            if (engineOn)
            {
                Console.WriteLine("The car is driving.");
                return "The car is driving.";
            }
            else
            {
                Console.WriteLine("The engine is not on.");
                return "The engine is not on.";
            }
        }

        
        public override string ToString()
        {
            return $"{Brand} {Model} {Year}";
        }
    }
}