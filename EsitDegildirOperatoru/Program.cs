using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsitDegildirOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Eşit Değildir operatörü = != (bir ve birden fazla işlemde kullanılabilir.)
            int number1 = 7;

            int number2 = 7;    

            bool control = number1 != number2;

            Console.WriteLine(control);
            Console.ReadLine();


        }
    }
}
