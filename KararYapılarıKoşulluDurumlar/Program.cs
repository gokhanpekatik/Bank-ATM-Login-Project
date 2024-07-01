using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapılarıKoşulluDurumlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Koşullu Durumlar (Karar Yapıları, Kontrol Yapıları) 
            // if (şart) - else
            // if = eğer(şart)  else = başka,diğer,yoksa,değilse

            int note = 23;

            if (note > 50)
            {
                Console.WriteLine("Öğrenci bu dersten başarılı bir şekilde geçmiştir.");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Dersten başarısız oldunuz.");
                Console.ReadLine();
            }


        }
    }
}
