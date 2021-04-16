using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {

        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi: " + urun.Ad);
        }

        //Yanlış bi kullanım bir parametre eklediğimizde her yerden değiştirmek zorunda kalırız
        public void Ekle2(string urunAdi, string aciklama, double fiyat,int stokAdedi)
        {
            Console.WriteLine("Sepete Eklendi: " + urunAdi);
        }
    }
}
