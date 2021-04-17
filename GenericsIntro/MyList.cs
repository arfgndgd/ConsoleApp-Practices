using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //Generic Class
    {
        //Generic 
        T[] items;

        //Constructor => Bir class new edildiğinde çalışan blok constructordır.
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            //geçici dizi
            T[] tempArray = items;
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        public int Count
        {
            get { return items.Length; }
        }

    }
}
