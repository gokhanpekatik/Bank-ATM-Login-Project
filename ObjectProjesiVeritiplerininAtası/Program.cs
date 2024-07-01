using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectProjesiVeritiplerininAtası
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // object veritipi tüm veritiplerini tanıyan ve değerlerini tutabilen büyük bir veritipidir.(veritiplerinin atası)
            object trial1 = 2221.1222;
            object trial2 = "deneme";
            object trial3 = "deneme 2";
            object trial4 = 'g'; //char veritipinin yaptığını yapabilir ve diğerleri gibi hata vermez.
            object trial5 = 30000;
            object trial6 = true;
            object trial7 = false;
            object trial8 = 7 > 4;

            Console.WriteLine(trial1);
            Console.WriteLine(trial2);
            Console.WriteLine(trial3);
            Console.WriteLine(trial4);
            Console.WriteLine(trial5);
            Console.WriteLine(trial8);
            
            Console.ReadLine();

        }
    }
}
