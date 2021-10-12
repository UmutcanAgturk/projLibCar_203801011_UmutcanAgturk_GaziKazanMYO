using System;

namespace Vehicle
{
    public class vehicle
    {

        private double FuelCapacity;
        public double fuelCapacity { get => FuelCapacity; set => FuelCapacity = value; }

        private double FuelConsumption;
        public double fuelConsumption { get => FuelConsumption; set => FuelConsumption = value; }

        private string FuelTypee;
        public string fuelTypee { get => FuelTypee; set => FuelTypee = value; }

        private int EngineCapaticy;
        public int engineCapatcicy { get => EngineCapaticy; set => EngineCapaticy = value; }

        private int Speed;
        public int speed { get => Speed; set => Speed = value; }

        private byte Door;
        public double door { get => Door; set => Door = (byte)value; }

        private int SeatingCapaity;
        public int seatingCapaity { get => SeatingCapaity; set => SeatingCapaity = value; }

        private string Model;
        public string  model { get => Model; set => Model = value; }

        private string Brand;
        public string brand { get => Brand; set => Brand = value; }

        private string LuggageCapacity;
        public string luggageCapaity { get => LuggageCapacity; set => LuggageCapacity = value; }

        private int NumberofWheels;
        public int numberOfWheels { get => NumberofWheels; set => NumberofWheels = value; }



    }
}
