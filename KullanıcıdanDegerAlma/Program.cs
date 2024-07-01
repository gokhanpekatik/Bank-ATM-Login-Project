using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanıcıdanDegerAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ReadLine kullanılarak kullanıcıdan değer alınabilir.

            Console.WriteLine("Lütfen adınızı giriniz");

            string isim = Console.ReadLine(); // değer almak için

            Console.WriteLine("Soyisminizi giriniz");

            string soyisim = Console.ReadLine(); // değer almak için

            Console.WriteLine("Kullanıcının ismi:" + isim);
            Console.WriteLine("Kullanıcının soyadı:"+ soyisim);  

            Console.ReadLine();


        }
    }
}
