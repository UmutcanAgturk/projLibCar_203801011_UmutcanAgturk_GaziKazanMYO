using System;
using System.Collections.Generic;
using System.Text;
using Vehicle;

namespace Vehicle
{
    public class car : vehicle //Integration of car class by inheriting vehicle class.
    {
        private string Bluetooth;
        public string bluethooth { get => Bluetooth; set => Bluetooth = value.ToUpper(); }//Enlarge all string data

        private string AirConditioning;
        public string airConditioning { get => AirConditioning; set => AirConditioning = value.ToUpper(); }//Enlarge all string data

        private string BodyType;
        public string bodyType { get => BodyType; set => BodyType = value.ToUpper(); }//Enlarge all string data

        private string Variant;
        public string variant { get => Variant; set => Variant = value.ToUpper(); }//Enlarge all string data

        private int Year;
        public int year //Using try catch numeric data.
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
