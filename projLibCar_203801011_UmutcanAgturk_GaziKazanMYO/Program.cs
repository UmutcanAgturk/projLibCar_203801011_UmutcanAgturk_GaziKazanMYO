using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle;



namespace projLibCar_203801011_UmutcanAgturk_GaziKazanMYO
{
    class Program
    {
        static void Main(string[] args)
        {
            vehicle vhc = new vehicle();
            int carnumb;
            Console.WriteLine("Kaç Adet Araç Bilgisi Gireceksiniz?");
            carnumb = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < carnumb; i++)
            {
                
                Console.WriteLine("Aracınızın Markası Nedir?");
               



            }
        }
    }
}
