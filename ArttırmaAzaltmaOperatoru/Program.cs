using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArttırmaAzaltmaOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arttırma operatörü = ++ 
            // Azaltma operatörü  = -- 

            int number1 = 77; 
            int number2 = 77;
            
            number1--;  // kodlar yukarıdan aşağıya doğru sırayla çalışır.
            number2++;
            Console.WriteLine(number1);
            Console.WriteLine(number2);

            Console.ReadLine(); 

        }
    }
}
