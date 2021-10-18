using System;

namespace Vehicle
{
    internal class vehicle 
    {
    
        private double FuelCapacity;
        public double fuelCapacity//Using try catch numeric data.
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
        public double fuelConsumption//Using try catch numeric data.
        {
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
        public string fuelTypee { get => FuelTypee; set => FuelTypee = value.ToUpper(); }//Enlarge all string data

        private int EngineCapaticy;
        public int engineCapatcicy //Using try catch numeric data.
        {
            get 
            {
                return EngineCapaticy;
            }
            set 
            {
                try
                {
                    EngineCapaticy = value; 
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lütfen Sadece Sayısal Veri Giriniz");
                }

            }
        } 
        
        private double MaxSpeed;
        public double maxSpeed //Using try catch numeric data.
        {
            get
            {
                return MaxSpeed;
            }
            set
            {
                try
                {
                    MaxSpeed = value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lütfen Sadece Sayısal Veri Giriniz");
                }
                

            }
        }

        private int Door;
        public int door //Using try catch numeric data.
        {
            get
            {
                return Door;
            }
            set
            {
                
                try
                {
                    Door = value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lütfen Sadece Sayısal Veri Giriniz");
                }
            }
        }

        private int SeatingCapaity;
        public int seatingCapaity //Using try catch numeric data.
        {
            get
            {
                return SeatingCapaity;
            }
            set
            {
               
                try
                {
                    SeatingCapaity = value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lütfen Sadece Sayısal Veri Giriniz");
                }

            }
        }

        private string Model;
        public string  model { get => Model; set => Model = value.ToUpper(); }//Enlarge all string data

        private string Brand;
        public string brand { get => Brand; set => Brand = value.ToUpper(); }//Enlarge all string data

        private double LuggageCapacity;
        public double luggageCapaity //Using try catch numeric data.
        {
            get
            {
                return LuggageCapacity;
            }
            set
            {
                
                try
                {
                    LuggageCapacity = value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lütfen Sadece Sayısal Veri Giriniz");
                }
            }
        }

        private int NumberofWheels;
        public int numberOfWheels //Using try catch numeric data.
        {
            get
            {
                return NumberofWheels;
            }
            set
            {
                
                try
                {
                    NumberofWheels = value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lütfen Sadece Sayısal Veri Giriniz");
                }
            }
        }



    }
}
