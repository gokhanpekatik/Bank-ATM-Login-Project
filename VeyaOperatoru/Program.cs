using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeyaOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Veya operatörü = ||  (altgr ve z tuşunun solundaki tuşa aynı anda basılarak oluşturulur-yazılır.)
            // Veya operatörü(||) bir tane bile true olursa (true) verir.
            // ama veya operatörü hiç bir şart sağlanmamışsa(bir tane bile) (false) verir.
            int number1 = 5;
            int number2 = 8;
            int number3 = 4;

            bool control = number1 > number3 || number2 < number3; // true

            Console.WriteLine(control);

            Console.ReadLine();
            

        }
    }
}
