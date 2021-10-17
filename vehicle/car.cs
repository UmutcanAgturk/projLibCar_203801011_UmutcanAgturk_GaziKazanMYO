using System;
using System.Collections.Generic;
using System.Text;
using Vehicle;

namespace Vehicle
{
    public class car : vehicle
    {
        private string Bluetooth;
        public string bluethooth { get => Bluetooth; set => Bluetooth = value.ToUpper(); }

        private string AirConditioning;
        public string airConditioning { get => AirConditioning; set => AirConditioning = value.ToUpper(); }

        private string BodyType;
        public string bodyType { get => BodyType; set => BodyType = value.ToUpper(); }

        private string Variant;
        public string variant { get => Variant; set => Variant = value.ToUpper(); }

        private int Year;
        public int year 
        {
            get 
            {
                return Year;
            }
            set 
            {
                
                try
                {
                    Year = value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lütfen Sadece Sayısal Veri Giriniz");
                }
            } 
        }
        
    }
    
}
