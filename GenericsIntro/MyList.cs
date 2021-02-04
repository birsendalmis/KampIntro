using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            //geciciDizi
            T[] tempArray = items;//böyle yapınca elemanlar kaybolmamış olur.elemanları geçici bir yerde tuttu. 
            items = new T[items.Length + 1];//dizinin eleman sayısını 1 arttırdı.
            //for ile geçicideki elemanları geri alıyor.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }
    }
}
