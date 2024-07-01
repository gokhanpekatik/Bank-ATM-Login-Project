using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bool veritipi 2 tane ihtimalin olduğu yerlerde kullanılır.
            // örnek olarak: Ali yemeğini yedimi? Cevap1= evet-true(yedi) Cevap2= hayır-false(yemedi)
            // bool veritipi sadece (true) ve (false) değerlerini tutar dışındakileri tutamaz hata verir.
            // true=Doğru / false=yanlış
            bool control1 = true;  // örnektir
            bool control2 = false; // örnektir

            bool result = 10 > 8; 

            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
