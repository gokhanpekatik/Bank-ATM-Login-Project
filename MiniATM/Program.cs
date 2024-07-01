using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MiniATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int balance = 1000;
                // Kullanıcıya soracağız nasıl bir işlem yapmak istediğini 
                // 1. Bakiye görüntüleme
                // 2. Para Çekme 
                // 3. Para Yatırma 
                // 4. q'ya('q' karakterine) basarsa çıkış yaptıracağız.

                Console.WriteLine("ATM'ye hoşgeldiniz!");
                Console.WriteLine("Nasıl bir işlem yapmak istiyorsunuz seçin!");
                Console.WriteLine("İşlemler: 1  -  2  -  3  -  q");
                Console.WriteLine("Çıkış yapmak için q'ya basın.");
                string choose = Console.ReadLine();

                if (choose == "1")
                {
                    Console.WriteLine("Şuan ki bakiyeniz:" + balance + "TL");
                }
                else if (choose == "2")
                {
                    Console.WriteLine("Çekmek istediğiniz tutarı girin:");
                    int pull = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("İşlem başarılı Kalan Tutar:" + (balance - pull) + "TL");
                }

                else if (choose == "3")
                {
                    Console.WriteLine("Yatırmak istediğiniz tutarı giriniz:");
                    int deposit = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("İşlem başarılı Güncel bakiye:" + (balance + deposit) + "TL");

                }
                else if (choose == "q")
                {
                    Console.WriteLine("ATM'den çıkış yapılıyor...");
                    Console.WriteLine("Çıkış yapıldı...");

                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir değer giriniz.");

                }
                Console.ReadLine();
            }
                 
            
        }
    }
}
