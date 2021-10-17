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
            car mycar = new car();
            int carnumb = 0;
            Console.WriteLine("Kaç Adet Araç Bilgisi Gireceksiniz?");
            carnumb = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < carnumb; i++)
            {

                {

                    string dosyaYol = @"Vehicle.txt";
                    FileStream fs = new FileStream(dosyaYol, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);


                    Console.WriteLine("Aracınızın Markası Nedir?");
                    mycar.brand = Convert.ToString(Console.ReadLine());
                    sw.WriteLine("Araba Markası:" + mycar.brand);

                    Console.WriteLine("Aracınızın Modeli Nedir?");
                    mycar.model = Convert.ToString(Console.ReadLine());
                    sw.WriteLine("Aracınızın Modeli:" + mycar.model);

                    Console.WriteLine("Aracınızın Varyantı Nedir?");
                    mycar.variant = Convert.ToString(Console.ReadLine());
                    sw.WriteLine("Aracınızın Varyantı:" + mycar.variant);

                    Console.WriteLine("Aracınızın Karoseri Tipi Nedir?");
                    mycar.bodyType = Convert.ToString(Console.ReadLine());
                    sw.WriteLine("Aracınızın Karoseri Tipi:" + mycar.bodyType);

                    Console.WriteLine("Aracınızın Motor Hacmi Nedir?");
                    mycar.engineCapatcicy = Convert.ToInt32(Console.ReadLine());
                    sw.WriteLine("Aracınızın Motor Kapasitesi:" + mycar.engineCapatcicy);

                    Console.WriteLine("Aracınızın Yakıt Türü Nedir?");
                    mycar.fuelTypee = Convert.ToString(Console.ReadLine());
                    sw.WriteLine("Aracınızın Yakıt Türü:" + mycar.fuelTypee);

                    Console.WriteLine("Aracınızın 100 Kilometrede Ortalama Yakıt Tüketimi Kaçtır?");
                    mycar.fuelConsumption = Convert.ToDouble(Console.ReadLine());
                    sw.WriteLine("Aracınızın 100 Kilometrede Ortalama Yakıt Tüketimi:" + mycar.fuelConsumption);

                    Console.WriteLine("Aracınızın Yakıt Kapasitesi Kaçtır?");
                    mycar.fuelCapacity = Convert.ToDouble(Console.ReadLine());
                    sw.WriteLine("Aracınızın Yakıt Kapasitesi:" + mycar.fuelCapacity);

                    Console.WriteLine("Aracınızın Koltuk Sayısı Kaçtır?");
                    mycar.seatingCapaity = Convert.ToInt16(Console.ReadLine());
                    sw.WriteLine("Aracınızın Koltuk Sayısı:" + mycar.seatingCapaity);

                    Console.WriteLine("Aracınızın Kapı Sayısı Kaçtır?");
                    mycar.door = Convert.ToInt16(Console.ReadLine());
                    sw.WriteLine("Aracınızın Kapı Sayısı:" + mycar.door);

                    Console.WriteLine("Aracınızın Tekerlek Sayısı Kaçtır?");
                    mycar.numberOfWheels = Convert.ToInt32(Console.ReadLine());
                    sw.WriteLine("Aracınızın Tekerlek Sayısı:" + mycar.numberOfWheels);

                    Console.WriteLine("Aracınızın Bagaj Kapasitesi Kaçtır?(Litre Olarak)");
                    mycar.luggageCapaity = Convert.ToDouble(Console.ReadLine());
                    sw.WriteLine("Aracınızın Bagaj Kapasitesi:" + mycar.luggageCapaity);

                    Console.WriteLine("Aracınızın Maksimum Hızı Kaçtır?");
                    mycar.maxSpeed = Convert.ToDouble(Console.ReadLine());
                    sw.WriteLine("Aracınızın Maksimum Hızı:" + mycar.maxSpeed);

                    Console.WriteLine("Aracınızın Üretim Yılı Kaçtır?");
                    mycar.year = Convert.ToInt32(Console.ReadLine());
                    sw.WriteLine("Aracınızın Üretim Yılı:" + mycar.year);

                    Console.WriteLine("Aracınızın Kliması Var Mı?");
                    mycar.airConditioning = Convert.ToString(Console.ReadLine());
                    sw.WriteLine("Aracınızın Kliması:" + mycar.airConditioning);
                    
                    Console.WriteLine("Aracınızın Bluetooth Var Mı?");
                    mycar.bluethooth = Convert.ToString(Console.ReadLine());
                    sw.WriteLine("Aracınızın Bluetooth'u:" + mycar.bluethooth);

                    sw.WriteLine();
                    sw.WriteLine();
                    sw.WriteLine();
                    sw.WriteLine();

                    sw.Flush();
                    sw.Close();
                    sw.Close();

                }

            }
            Console.ReadKey();
        }
    }
}
