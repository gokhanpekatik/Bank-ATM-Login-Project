using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // double veri tip 15 basamaklı ondalık sayı değerlerini tutar-depolar.
            // 8 byte yer kaplar.
            double firstvalue = 22.222462113;
            double secondvalue = 52.12205;
            double maxvalue = double.MaxValue;  
            double minvalue = double.MinValue;

            Console.WriteLine(firstvalue); 
            Console.WriteLine(secondvalue); 
            Console.WriteLine(maxvalue);    
            Console.WriteLine(minvalue);    

            Console.ReadLine();

        }
    }
}
