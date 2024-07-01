using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // do while döngüsü 

            //int i = 1;

            /*do
            {
                Console.WriteLine(i);
                i++;


            } while (i<=10);*/

            int a = 1;
            int total = 0;
            do
            {
                total += a;
                a++;

            } while (a <= 100);

            Console.WriteLine("1'Den 100'e kadar olan sayıların toplamı: " + total);
            Console.ReadLine();
        }
    }
}
