using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatörler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Toplama operatörü = + (bir ve birden fazla şey toplanabilir.)
            // Çıkarma operatörü = - (bir ve birden fazla şey çıkarılabilir.)
            int number = 5;
            int number2 = 5;

            int result = number + number2;
            int result2 = number + number - number2; //matematikte işlem önceliği soldan başlar sağa doğru bu kullanılır veya parantezle biraz daha kolaylaştırılabilir.

            Console.WriteLine(result);  
            Console.WriteLine(result2); 

            Console.ReadLine();
        }
    }
}
