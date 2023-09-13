using System;
//using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;

namespace AdvProgramming
{
    class CollectionsDemo2
    {
        static void Main()
        {
            //Requirement of ArrayList over Array:
            //Should go for ArrayList only when your requirement is to inserting/ deleting elements in middle positions and not fixed size. Otherwise use Array only.

            //Diff b/w ArrayList & Array:
            Console.WriteLine(DateTime.Now);//15-05-2023 09:39:50
            Console.WriteLine(DateTime.Now.Second);//We can fetch Date, Month, Year, Hours, Minutes, Seconds.

            Stopwatch watch = new Stopwatch(); //using System.Diagnostics;
            //If you don't know which namespace is to import just type-in the class name -> Place the Cursor -> ""Show Potential fixes -> select the appropriate one.
            //StopWatch is used to calculate the elapsed or execution time for a block of program.
            watch.Start();
            ArrayList al = new ArrayList();
            for(int i=0;i<100;i++)
                al.Add(DateTime.Now.Second);//We are storing seconds in all cells of ArrayList
            //al.Add(123567);
            watch.Stop();
            Console.WriteLine(watch.Elapsed.TotalSeconds);//4.7E-05 [Scientific Notation]

            Stopwatch watch1 = new Stopwatch();
            watch1.Start();
            int[] arr = new int[100];
            for (int i = 0; i < 100; i++)
                arr[i] = DateTime.Now.Second;
                //arr[i] = 123567;
            watch1.Stop();
            Console.WriteLine(watch1.Elapsed.TotalSeconds);//3.06E-05
            //ArrayList took more time than Array, because it took the data in the form of object and then convert into respective type using Boxing& Un-boxing. For each element boxing & unboxing is required then only it store in ArrayList. Same happens with HashTable, Stack, Queue. So, if the data is more it will lower the performance bcs of Boxing& un-boxing. 
            //Incase of Arrays, in the definition itself we are defining the type of data. So, boxing and Unboxing is not required. Performance wise Arrays are good than ArrayList.
            //Maintanance of ArrayList is better than Array. 
            //If you are dealing with huge data and continuous modifications then go with Arrays.
        }
    }
}
