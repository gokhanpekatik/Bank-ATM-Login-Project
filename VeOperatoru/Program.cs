using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ve operatörü = && (shift+6=)
            // Ve operatörü(&&) belirtilen tüm şartlar sağlanmışsa "true" verir. 

            int number1 = 4;
            int number2 = 4;
            int number3 = 6;

            bool control = number1 == number2 && number1 < number3; // Ve operatörü(&&) belirtilen tüm şartlar sağlanmışsa "true" verir. 

            Console.WriteLine(control);

            Console.ReadLine();

        }
    }
}
