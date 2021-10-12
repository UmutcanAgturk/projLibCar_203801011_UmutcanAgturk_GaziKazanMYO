using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class car : vehicle
    {
        private string Bluetooth;
        public string bluethooth { get => Bluetooth; set => Bluetooth = value; }

        private string AirConditioning;
        public string airConditioning { get => AirConditioning; set => AirConditioning = value; }

        private string BodyType;
        public string bodyType { get => BodyType; set => BodyType = value; }

        private string Variant;
        public string variant { get => Variant; set => Variant = value; }

        private string Year;
        public string year { get => Year; set => Year = value; }

    }
    
}
