using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucukveKucukEsittirOperatorleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Küçüktür operatörü = < 
            // Küçük Eşittir operatörü = <=

            int ayakkabısayısı = 42;
            
            bool control1 = ayakkabısayısı < 25; // false
            bool control2 = ayakkabısayısı <= 42; // true 

            Console.WriteLine(control1);
            Console.WriteLine(control2);
            
            Console.ReadLine();

        }
    }
}
