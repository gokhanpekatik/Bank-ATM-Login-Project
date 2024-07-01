using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosulYapısıNotOrnegi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen notlarınızı giriniz.");
            int imputnote1 = Convert.ToInt32(Console.ReadLine());    
            
            int imputnote2 = Convert.ToInt32(Console.ReadLine());    

            int imputnote3 = Convert.ToInt32(Console.ReadLine());


            int result = (imputnote1 + imputnote2 + imputnote3) / 3;

            if (result>80 && result<100)
            {
                Console.WriteLine("Not değeriniz A+");
            }

            else if (result>60 && result<80) // else if birden fazla şart-koşul olduğu durumlarda kullanılır.
            {
                Console.WriteLine("Not değeriniz A");
            }

            else if (result > 40 && result < 60)
            {
                Console.WriteLine("Not değeriniz B+");
            }

            else 
            {
                Console.WriteLine("Not değeriniz F");
            }

            Console.ReadLine();

  

        }
    }
}
