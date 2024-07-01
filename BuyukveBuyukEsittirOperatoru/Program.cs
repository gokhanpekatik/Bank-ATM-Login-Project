using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukveBuyukEsittirOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Büyüktür operatörü = >
            // Büyük Eşittir operatörü = >= 

            int age = 18;

            bool control1 = age > 18; // 18 değeri 18'den büyük değildir. (false)
            bool control2 = age >= 18; // 18 değeri 18'den büyük değildir ama 18'e eşittir. (true)


            Console.WriteLine(control1);
            Console.WriteLine(control2);    

            Console.ReadLine();

        }
    }
}
