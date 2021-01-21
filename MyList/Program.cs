using System;
using System.Collections.Generic;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            Mylist<string> mylist = new Mylist<string>();
            mylist.Add("Ali");
            mylist.Add("Veli");
        }
        class Mylist<T>
        {
            T[] Items;
            T[] Temporary;
            public Mylist()
            {
               Items = new T[0];
            }
            public void Add(T item)
            {
              Temporary = Items;
                Items = new T[Items.Length + 1];
                for(int i=0;i<Temporary.Length;i++)
                {
                    Items[i] = Temporary[i];
                }
                Items[Items.Length - 1] = item;
            }
        }
    }
}
