using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpmaBolmeOperatorleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // çarpma operatörü = / (bir ve birden fazla şey çarpılabilir.)
            // bölme operatörü = *  (bir ve birden fazla şey bölünnebilir.)
            // mod-kalan alma operatörü = % (bir ve birden fazla şeyin kalanı-modu alınabilir.)
            int number1 = 5; 
            int number2 = 3;

            int result1 = number1 * number2;
            int result2 = number1 / number2;
            int result3 = number1 % number2; // mod operatörü(aracı) bölme işlemindeki çıkan kalanı verir.
            int result4 = (number1 % number2) + number2; // işlem önceliği dahada belirtilmek(şık görünmesi) istenirse koyulabilir.

            Console.WriteLine(result1); 
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.ReadLine();

        }
    }
}
