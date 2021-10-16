using System;
using System.IO;

namespace Vehicle
{
    public class vehicle 
    {
    
        private double FuelCapacity;
        public double fuelCapacity
        {
            
            get
            { 
                return FuelCapacity;
            }

            set
            {
                try
                {
                    FuelCapacity = value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lütfen Sadece Sayısal Veri Giriniz");
                }
            }
        }

        private double FuelConsumption;
        public double fuelConsumption {
            get
            {
                return FuelConsumption;
            }
            set
            {
                try
                {
                    FuelConsumption = value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lütfen Sadece Sayısal Veri Giriniz");
                }

            }
        }

        private string FuelTypee;
        public string fuelTypee { get => FuelTypee; set => FuelTypee = value; }

        private int EngineCapaticy;
        public int engineCapatcicy {  get => EngineCapaticy; set => EngineCapaticy = value; } 
        

        private double Speed = 0 ;
        public double speed { get => Speed; set => Speed = value; }

        private double MaxSpeed;
        public double maxSpeed { get => MaxSpeed; set => MaxSpeed = value; }

        private int Door;
        public int door { get => Door; set => Door = value; }

        private int SeatingCapaity;
        public int seatingCapaity { get => SeatingCapaity; set => SeatingCapaity = value; }

        private string Model;
        public string  model { get => Model; set => Model = value; }

        private string Brand;
        public string brand { get => Brand; set => Brand = value; }

        private double LuggageCapacity;
        public double luggageCapaity { get => LuggageCapacity; set => LuggageCapacity = value; }

        private int NumberofWheels;
        public int numberOfWheels { get => NumberofWheels; set => NumberofWheels = value; }



    }
}
