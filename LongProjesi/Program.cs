using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Long veri tipi -9223372036854775808, 9223372036854775807 arasında değer depolar.
            long firstvalue = 1000000;
            long secondvalue = -2000000;
            long minvalue = long.MinValue;
            long maxvalue = long.MaxValue;  

            Console.WriteLine(firstvalue);
            Console.WriteLine(secondvalue);
            Console.WriteLine(minvalue);
            Console.WriteLine(maxvalue);

            Console.ReadLine();

        }
    }
}
