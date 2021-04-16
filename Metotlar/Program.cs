using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 10;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Ad = "Elma";
            urun1.Fiyat = 10;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Ad = "Karpuz";
            urun2.Fiyat = 20;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };


            //type-safe => tip güvenliği anlamına gelir "var" veri tipi olarak kullansakta bir şey olmaz c# ve java dilleri type-safe'tir.
            foreach (Urun item in urunler)
            {
                Console.WriteLine(item.Ad+", " +item.Fiyat+ ", "+item.Aciklama);
                
            }

            Console.WriteLine("--------------------Metotlar---------------------");

            //instance - örnek
            SepetManager sepet = new SepetManager();
            sepet.Ekle(urun1);
            sepet.Ekle(urun2);

            sepet.Ekle2("Elma","Yeşil Elma",5,80);
            sepet.Ekle2("Erik","Yeşil Erik",7,70);

        }
    }
}
