using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öğrenci_uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kontrol= true;
            Ogrenci ogrenci1 = new Ogrenci(10, "ozan", "sevim", 60, 50, "Aksaray üniversitesi");

            Console.WriteLine("Uygulamaya hoşgeldiniz......");
            islemlerGoster();

            
            while(kontrol)
            {
                string secim = Console.ReadLine();

                switch(secim)
                {
                    case "1":
                        ogrenci1.ogrenciBilgileriGöster();
                        break;

                    case "2":
                        double OgrenciOrtalama=ogrenci1.OgrencinotBul();
                        Console.WriteLine("ogrenci ortalaması: "+OgrenciOrtalama);
                        break;

                    case "3":
                        ogrenci1.okulGetir();
                        break;

                        case "4":
                        kontrol = false;
                        break;             
                }
            }
        }

        static void islemlerGoster()
        {
            Console.WriteLine("Öğrenci bilgilerini göster");
            Console.WriteLine("öğrenci ortalamasını göster");
            Console.WriteLine("Öğrenci okulunu göster");
            Console.WriteLine("cıkış yap");
        }
    }
}
