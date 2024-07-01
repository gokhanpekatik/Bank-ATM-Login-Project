using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // short değişkeni -30.000, +30.000 arasında değer depolayabilir.
            short maxvalue = short.MaxValue;

            short minimumvalue = short.MinValue;

            short firstvalue = -15000;

            short secondvalue = 15000;



            Console.WriteLine(maxvalue); 
            Console.WriteLine(minimumvalue);
            Console.WriteLine(firstvalue);  
            Console.WriteLine(secondvalue);
            
            Console.ReadLine();
            
        }
    }
}
