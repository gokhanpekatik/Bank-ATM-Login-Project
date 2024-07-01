using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //// Tür Dönüşümleri (veri tipi dönüşümleri)

            //int a = 6; // a değişkeni int veritipinde bu alttaki kodda ise byte veritipine dönüştürdüm-çevirdim.

            //string c = "236"; // string veri tipini int'e dönüştürmek için string'te sayı olmalıdır-girilmelidir.

            //string e = "53";

            //byte b = (byte)a; // eşitliğin her iki tarafı aynı veritipinde(byte byte'ta gibi) olmalıdır.
            //int d = int.Parse(c); //string veri tipini diğer veri tiplerine dönştürürken veritipi.parse(dönüştür) kullanılır.
            //int f = Convert.ToInt32(e); // 2'ci yöntem toint32 yöntemidir diğer 1.'si ise parse(dönüştür) yöntemidir.


            //// double veritipinden int veri tipine nasıl dönüştürülür.

            //double g = 23.122;

            //int h = Convert.ToInt32(g);


            // Kullanıcıdan alınan değerler çoğunlukla string veritipinde olur ... 
            // string(yazı) veritipi ile toplama-çıkarma vb. gibi işlemlerde iş görmeyecektir o yüzden int veritipine dönüştürülür.

            /*Console.WriteLine("Lütfen yaşınızı giriniz!");


            string kullanıcı_yas = Console.ReadLine();
            int kullanıcı_yasInt = int.Parse(kullanıcı_yas);
            int kullanıcı_yasıInt2 = Convert.ToInt32(kullanıcı_yas);



            Console.WriteLine(kullanıcı_yasInt);
            Console.WriteLine(kullanıcı_yasıInt2);

            Console.ReadLine(); */


            // kullanıcıdan 2 tane sayı alan ve ikisinin toplamını ekrana yazdıran programı yazınız.

            while (true)
            {
                Console.WriteLine("Toplamak istediğiniz 1. sayıyı giriniz!");
                string imput1 = Console.ReadLine();

                Console.WriteLine("Toplamak istediğiniz 2. sayıyı giriniz!");
                string imput2 = Console.ReadLine();

                int convert1 = int.Parse(imput1); // daha fazla sayı basamağı-hanesi girebilmek için veritabınının Long olması lazım.
                int convert2 = int.Parse(imput2);


                Console.Write("Toplam:" + (convert1 + convert2));
                Console.ReadLine();


                // Veri Tipi dönüştürme yöntemleri-metodları-fonksiyonları

                // ToString(); (strin'e dönüştürme)
                // Convert.ToInt(); (Int'e dönüştürme)
                // int.parse(); (Int'e dönüştürme)
                // double.parse(); (double'a dönüştürme)
                // 

            }

        }
    }
}
