using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaAtmUygılaması
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ATM");
            int pin = 1111;

            Console.WriteLine("Pini girin!");
            int imput_pin = Convert.ToInt32(Console.ReadLine());

            if (imput_pin==pin)
            {

                Console.WriteLine("ATM'ye Hoş Geldiniz!");
                Console.ReadLine();

            }


            else if (imput_pin!=pin)
            {

                Console.WriteLine("Pin hatalı lütfen tekrar deneyin. (3 deneme hakkınız var.!)");
                Console.ReadLine();

            }

            Console.WriteLine("Pini girin!");
            int imput_pin2 = Convert.ToInt32(Console.ReadLine());

            if (imput_pin2==pin)
            {

                Console.WriteLine("ATM'ye Hoş Geldiniz!");
                Console.ReadLine();

            }

            else if (imput_pin2 != pin)
            {

                Console.WriteLine("Pin hatalı lütfen tekrar deneyin. (2 deneme hakkınız var!)");
                Console.ReadLine();

            }


            Console.WriteLine("Pini girin!");
            int imput_pin3 = Convert.ToInt32(Console.ReadLine());

            if (imput_pin3 == pin)
            {

                Console.WriteLine("ATM'ye Hoş Geldiniz!");
                Console.ReadLine();

            }

            else if (imput_pin3 != pin)
            {

                Console.WriteLine("Pin hatalı lütfen tekrar deneyin. (1 deneme hakkınız var!)");
                Console.ReadLine();

            }


            Console.WriteLine("Pini girin!");
            int imput_pin4 = Convert.ToInt32(Console.ReadLine());

            if (imput_pin4 == pin)
            {

                Console.WriteLine("Hesabınız bloke oldu. Lütfen bankanızla iletişime geçin.");
                Console.ReadLine();

            }

            else if (imput_pin4 != pin)
            {

                Console.WriteLine("Hesabınız bloke oldu. Lütfen bankanızla iletişime geçin.");
                Console.ReadLine();

            }


            Console.ReadLine();


        }
    }
}
