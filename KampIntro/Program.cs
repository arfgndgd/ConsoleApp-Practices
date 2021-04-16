using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği

            //string kategoriEtiketi = "Kategori";
            //int ogrenciSayisi = 32000;
            //double faizOrani = 1.45;
            //bool sistemeGirisYapmisMi = true;

            //if (sistemeGirisYapmisMi == true)
            //{
            //    Console.WriteLine("Kullanıcı ayarları butonu");
            //}
            //else
            //{
            //    Console.WriteLine("Giriş yap butonu");
            //}

            //Console.WriteLine(kategoriEtiketi);
            //Console.WriteLine(ogrenciSayisi);
            //Console.WriteLine(faizOrani);

            string[] kurslar = new string[] { "sarı", "kırmızı", "cimbom" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
