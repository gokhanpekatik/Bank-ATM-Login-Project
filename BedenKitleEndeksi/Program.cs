using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedenKitleEndeksi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Beden Kitle Endeksi Uygulaması 
            // Beden Kitle Endeksi = Kilo / boy*boy
            // Beden Kitle Endeksi 18'e eşit veya düşükse ZAYIF.
            // 25'ten büyükse OBEZ yazdıran program parçasını kodlayınız.
            while (true)
            {
                Console.WriteLine("Beden Kitle Endeksi Ölçer.");
                
                Console.WriteLine("Kilonuzu giriniz.");
                int weight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Boyunuzu giriniz.");
                double height = Convert.ToDouble(Console.ReadLine());


                double result = weight / (height * height); // işlem önceliği


                if (result<18.5)
                {
                    Console.WriteLine("Beden Kitle Endeksiniz:" + result);
                    Console.WriteLine("Zayıfsınız...");
                    Console.ReadLine();

                }

                else if (result==18.5 || result<24.9)
                {
                    Console.WriteLine("Beden Kitle Endeksiniz:" + result);
                    Console.WriteLine("Normal Kilolusunuz...");
                    Console.ReadLine();

                }

                else if (result==25 || result<29.9)
                {
                    Console.WriteLine("Beden Kitle Endeksiniz:" + result);
                    Console.WriteLine("Fazla Kilolusunuz...");
                    Console.ReadLine();

                }

                else if (result==30 || result<34.9)
                {
                    Console.WriteLine("Beden Kitle Endeksiniz:" + result);
                    Console.WriteLine("1. Derece Obezsiniz...");
                    Console.ReadLine();

                }

                else if (result==35 || result<39.9)
                {
                    Console.WriteLine("Beden Kitle Endeksiniz:" + result);
                    Console.WriteLine("2. Derece Obezsiniz...");
                    Console.ReadLine();

                }

                else if (result==40 || result>40)
                {
                    Console.WriteLine("Beden Kitle Endeksiniz:" + result);
                    Console.WriteLine("3. Derece (Morbid) Obezsiniz...");
                    Console.ReadLine();

                }


            }
        }
    }
}
