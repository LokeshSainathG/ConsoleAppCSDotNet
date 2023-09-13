using System;
using System.Collections;
using System.Diagnostics;

namespace AdvProgramming
{
    class HashTableDemo
    {
        static void Main()
        {
            //HashTable also has methods like ArrayList has except few.

            //ArrayList vs Hashtable:
            /*ArrayList is used to hold the data in the form of Object. HashTable also hold the data in form of Obj [Key-Value pair].
             * In ArrayList, index is pre-defined. In Hashtable, index is User-defined.
             */

            //Index is pre-defined in AL
            ArrayList al = new ArrayList();
            al.Add(1000);
            al.Add("Lokesh");
            al.Add(45000);
            al.Add("Developer");
            al.Add("Male");
            Console.WriteLine(al[1] + " your role is " + al[3]);
            //What if we have 1000 records. We have to run program first, count manually and then display the Position.
            Console.WriteLine("Given Array list: ");
            foreach (var item in al)
                Console.WriteLine(item + "  ");


            //Index is user-defined in HT.
            //It stores the data based on hasing algorithm. For each value there will be hash code.
            Hashtable ht = new Hashtable();//15 overloaded methods are there. You can pass capacity, ArrayList, 
            ht.Add("eno", 1000);//Keys should be unique
            ht.Add("ename", "Lokesh");
            ht.Add("sal", 45000);
            ht.Add("role", "Developer");
            ht.Add("gender", "Male");
            Console.WriteLine(ht["ename"] + " your role is " + ht["role"]);//we can easily access the data using keys.

            //Problem with Hashtable is we don't have much methods with Hashtable (AddRange(), RemoveRange(), RemoveAt(), Insert() methods are not availble). Since AL stores elements based on the Index.
            Console.WriteLine("Given Hashtable list: ");
            foreach (var item in ht.Keys)
                Console.WriteLine(ht[item] + "  ");//HT stores data based on Hashing algo, not like index based order. Forr each value, there will be  Hash code.

            ///////////////////////////////////////////////////
            //Performance check:
            Stopwatch watch1 = new Stopwatch();
            watch1.Start();
            Hashtable ht2 = new Hashtable();
            for (int i = 0; i < 1000; i++)
                ht2.Add(i, DateTime.Now.Second);
            watch1.Stop();
            Console.WriteLine("Hashtable execution time: " + watch1.Elapsed.TotalSeconds);//0.0018032

            Stopwatch watch2 = new Stopwatch();
            watch2.Start();
            ArrayList al2 = new ArrayList();
            for (int i = 0; i < 1000; i++)
                al.Add(DateTime.Now.Second);
            watch2.Stop();
            Console.WriteLine("Array List execution time: " + watch2.Elapsed.TotalSeconds);//0.0002766

            Stopwatch watch3 = new Stopwatch();
            watch3.Start();
            int[] arr = new int[1000];
            for (int i = 0; i < 1000; i++)
                arr[i] = DateTime.Now.Second;
            watch3.Stop();
            Console.WriteLine("Array execution time: "+watch3.Elapsed.TotalSeconds);//0.0002379
            //Hashtable took more time because of Hashing Algorithm.
            //In case if Project requirement is to define own Indices, then go with Hashtable.

        }
    }
}
