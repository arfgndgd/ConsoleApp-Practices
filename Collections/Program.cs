﻿using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Arif", "Murat" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]); 
            //Console.WriteLine(isimler[2]);

            //isimler = new string[4];
            //isimler[3] = "İlker";
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[0]);

            //Arrayde değil ama List içerisinde ekleme yapınnca ekleyebiliriz

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
