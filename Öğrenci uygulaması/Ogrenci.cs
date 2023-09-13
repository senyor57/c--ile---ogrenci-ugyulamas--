using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öğrenci_uygulaması
{
    public class Ogrenci
    {
        private int ogrno;
        private string isim;
        private string soyisim;
        private int vize;
        private int final;
        private string okulisim;
        public Ogrenci(int _ogrno, string _isim, string _soyisim, int _vize, int _final, string _okulismi )
        {
            ogrno = _ogrno;
            isim = _isim;
            soyisim = _soyisim;
            vize = _vize;
            final = _final;
            okulisim = _okulismi;

        }



        public void ogrenciBilgileriGöster()
        {
            Console.WriteLine("Öğrenci numarası: "+ ogrno);
            Console.WriteLine("Öğrenci ismi: " + isim);
            Console.WriteLine("Öğrenci soyismi: " + soyisim);
            Console.WriteLine("Vize notu: " + vize);
            Console.WriteLine("Final notu: " + final);
            Console.WriteLine("Okulun İsmi:"+ okulisim);

        }
          public double OgrencinotBul()
        {
            double ortalama = vize * 0.4 + final * 0.6;
            return ortalama;
        }
        
         public void okulGetir()
        {
            Console.WriteLine("Okulun ismi: "+okulisim);
        }

    }
}
