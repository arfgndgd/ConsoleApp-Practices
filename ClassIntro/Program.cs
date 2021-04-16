using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Arif";
            int yas = 25;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 45;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmen = "Engin Demiroğ";
            kurs2.IzlenmeOrani = 35;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "JAVA";
            kurs3.Egitmen = "Engin Demiroğ";
            kurs3.IzlenmeOrani = 85;

            //Console.WriteLine(kurs1.KursAdi+ " : " +kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3};

            foreach (Kurs item in kurslar)
            {
                Console.WriteLine(item.KursAdi);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
