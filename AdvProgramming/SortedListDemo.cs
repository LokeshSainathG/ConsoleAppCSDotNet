using System;
using System.Collections;

namespace AdvProgramming
{
    class SortedListDemo
    {
        static void Main()
        {
            //SortedList is collection of Key-Value pairs. Accessible by Keys/ Indicies. Indexing adjusted automatically.

            //A sorted list is a combination of an array and a hash table. It contains a list of items that can be accessed using a key or an index. If you access items using an index, it is an ArrayList, and if you access items using a key, it is a Hashtable
            SortedList sl = new SortedList();
            sl.Add(10, "Lokesh");
            sl.Add(11, " Sainath");
            sl.Add(12, " Gudivada");
            foreach (var item in sl)
                Console.WriteLine(item);//System.Collections.DictionaryEntry
            
            foreach (var item in sl.Keys)
                Console.Write(sl[item]);//Lokesh Sainath Gudivada
            Console.WriteLine();

            //Another way of Printing: Same we can use for Hashtable
            foreach (DictionaryEntry pair in sl)
                Console.WriteLine("{0} and {1}",
                          pair.Key, pair.Value);
            /*10 and Lokesh
            11 and  Sainath
            12 and  Gudivada*/

            //Removing element: By specifing the key
            sl.Remove(12);//Key based Removing
            //Removing element: By specifing the Index This is the Advantage of SortedList. We can use it like ArrayList, Hashtable.
            sl.RemoveAt(1);//Index based removing

            foreach (var item in sl.Keys)
                Console.Write(sl[item]);//Lokesh
            Console.WriteLine();

            //Clear entire SortedList
            sl.Clear();//No args
            Console.WriteLine("Elements in sl SortedList: "+sl.Count);//0
        }
    }
}
