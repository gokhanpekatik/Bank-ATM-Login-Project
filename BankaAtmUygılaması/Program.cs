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
Console.WriteLine("Lütfen pini girin:");

string pin = "1111";

int attempts = 3;

while (attempts > 0)
{
    string imput_pin = Console.ReadLine();  

    if (imput_pin == pin)
    {
        Console.WriteLine("Hoş geldiniz!");
        Thread.Sleep(3000);
        return;

    }

    else if (imput_pin != pin)  
    {
        attempts--;
        Console.WriteLine("Yanlış PIN. Kalan deneme hakkı:" + attempts);

    }

}

Console.WriteLine("Hesabınız bloke oldu, lütfen bankanızla iletişime geçin.");


Console.ReadLine();


        }
    }
}
