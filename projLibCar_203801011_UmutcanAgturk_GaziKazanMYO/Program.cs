using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Vehicle;



namespace projLibCar_203801011_UmutcanAgturk_GaziKazanMYO
{
    class Program
    {
        static void Main(string[] args)
        {
            car mycar = new car(); // I called car class
            int carnumb = 0; // Data preparation for the number of vehicles to be entered
            Console.WriteLine("Kaç Adet Araç Bilgisi Gireceksiniz?"); 
            carnumb = Convert.ToInt32(Console.ReadLine()); //Data transformation
            for (int i = 0; i < carnumb; i++) //Create a loop as many vehicles as desired
            {

                {

                    string filePath = @"Vehicle.txt"; // Added a token named filepath
                    FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write); //The path to the file where we will print our data and the .txt file method to create
                    StreamWriter sw = new StreamWriter(fs); //Method of writing data


                    Console.WriteLine("Aracınızın Markası Nedir?"); //Question to ask
                    mycar.brand = Convert.ToString(Console.ReadLine());//Passing the selected data to the method in our class
                    sw.WriteLine("Araba Markası:" + mycar.brand); //method to append the checked data to .txt file

                    Console.WriteLine("Aracınızın Modeli Nedir?");//Question to ask
                    mycar.model = Convert.ToString(Console.ReadLine());//Passing the selected data to the method in our class
                    sw.WriteLine("Aracınızın Modeli:" + mycar.model);//method to append the checked data to .txt file

                    Console.WriteLine("Aracınızın Varyantı Nedir?");//Question to ask
                    mycar.variant = Convert.ToString(Console.ReadLine());//Passing the selected data to the method in our class
                    sw.WriteLine("Aracınızın Varyantı:" + mycar.variant);//method to append the checked data to .txt file

                    Console.WriteLine("Aracınızın Karoseri Tipi Nedir?");//Question to ask
                    mycar.bodyType = Convert.ToString(Console.ReadLine());//Passing the selected data to the method in our class
                    sw.WriteLine("Aracınızın Karoseri Tipi:" + mycar.bodyType);//method to append the checked data to .txt file

                    Console.WriteLine("Aracınızın Motor Hacmi Nedir?");//Question to ask
                    mycar.engineCapatcicy = Convert.ToInt32(Console.ReadLine());//Passing the selected data to the method in our class
                    sw.WriteLine("Aracınızın Motor Kapasitesi:" + mycar.engineCapatcicy);//method to append the checked data to .txt file

                    Console.WriteLine("Aracınızın Yakıt Türü Nedir?");//Question to ask
                    mycar.fuelTypee = Convert.ToString(Console.ReadLine());//Passing the selected data to the method in our class
                    sw.WriteLine("Aracınızın Yakıt Türü:" + mycar.fuelTypee);//method to append the checked data to .txt file

                    Console.WriteLine("Aracınızın 100 Kilometrede Ortalama Yakıt Tüketimi Kaçtır?");//Question to ask
                    mycar.fuelConsumption = Convert.ToDouble(Console.ReadLine());//Passing the selected data to the method in our class
                    sw.WriteLine("Aracınızın 100 Kilometrede Ortalama Yakıt Tüketimi:" + mycar.fuelConsumption);//method to append the checked data to .txt file

                    Console.WriteLine("Aracınızın Yakıt Kapasitesi Kaçtır?");//Question to ask
                    mycar.fuelCapacity = Convert.ToDouble(Console.ReadLine());//Passing the selected data to the method in our class
                    sw.WriteLine("Aracınızın Yakıt Kapasitesi:" + mycar.fuelCapacity);//method to append the checked data to .txt file

                    Console.WriteLine("Aracınızın Koltuk Sayısı Kaçtır?");//Question to ask
                    mycar.seatingCapaity = Convert.ToInt16(Console.ReadLine());//Passing the selected data to the method in our class
                    sw.WriteLine("Aracınızın Koltuk Sayısı:" + mycar.seatingCapaity);//method to append the checked data to .txt file

                    Console.WriteLine("Aracınızın Kapı Sayısı Kaçtır?");//Question to ask
                    mycar.door = Convert.ToInt16(Console.ReadLine());//Passing the selected data to the method in our class
                    sw.WriteLine("Aracınızın Kapı Sayısı:" + mycar.door);//method to append the checked data to .txt file

                    Console.WriteLine("Aracınızın Tekerlek Sayısı Kaçtır?");//Question to ask
                    mycar.numberOfWheels = Convert.ToInt32(Console.ReadLine());//Passing the selected data to the method in our class
                    sw.WriteLine("Aracınızın Tekerlek Sayısı:" + mycar.numberOfWheels);//method to append the checked data to .txt file

                    Console.WriteLine("Aracınızın Bagaj Kapasitesi Kaçtır?(Litre Olarak)");//Question to ask
                    mycar.luggageCapaity = Convert.ToDouble(Console.ReadLine());//Passing the selected data to the method in our class
                    sw.WriteLine("Aracınızın Bagaj Kapasitesi:" + mycar.luggageCapaity);//method to append the checked data to .txt file

                    Console.WriteLine("Aracınızın Maksimum Hızı Kaçtır?");//Question to ask
                    mycar.maxSpeed = Convert.ToDouble(Console.ReadLine());//Passing the selected data to the method in our class
                    sw.WriteLine("Aracınızın Maksimum Hızı:" + mycar.maxSpeed);//method to append the checked data to .txt file

                    Console.WriteLine("Aracınızın Üretim Yılı Kaçtır?");//Question to ask
                    mycar.year = Convert.ToInt32(Console.ReadLine());//Passing the selected data to the method in our class
                    sw.WriteLine("Aracınızın Üretim Yılı:" + mycar.year);//method to append the checked data to .txt file

                    Console.WriteLine("Aracınızın Kliması Var Mı?");//Question to ask
                    mycar.airConditioning = Convert.ToString(Console.ReadLine());//Passing the selected data to the method in our class
                    sw.WriteLine("Aracınızın Kliması:" + mycar.airConditioning);//method to append the checked data to .txt file

                    Console.WriteLine("Aracınızın Bluetooth Var Mı?");//Question to ask
                    mycar.bluethooth = Convert.ToString(Console.ReadLine());//Passing the selected data to the method in our class
                    sw.WriteLine("Aracınızın Bluetooth'u:" + mycar.bluethooth);//method to append the checked data to .txt file

                    sw.WriteLine();//line skip
                    sw.WriteLine();//line skip
                    sw.WriteLine();//line skip
                    sw.WriteLine();//line skip

                    sw.Flush();//node creation
                    sw.Close();//node closed
                    sw.Close();//.txt file write off

                }

            }
            Console.ReadKey();
        }
    }
}
