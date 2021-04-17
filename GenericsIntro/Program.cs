using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //buradaki MyList ve List aslında birer classtır.
            MyList<string> isimler = new MyList<string>();
            Console.WriteLine(isimler.Count); //0
            isimler.Add("Arif");
            isimler.Add("Arif");
            isimler.Add("Arif");
            isimler.Add("Arif");
            isimler.Add("Arif");
            Console.WriteLine(isimler.Count);
            List<string> liste = new List<string>();
            liste.Add("Liste");
            liste.Add("Liste");
            liste.Add("Liste");
            liste.Add("Liste");
            Console.WriteLine(liste.Count); //1

            Console.WriteLine("Hello World!");
        }
    }
}
