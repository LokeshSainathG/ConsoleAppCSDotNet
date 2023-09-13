using System;
using System.Collections;
using System.Collections.Generic;

namespace AdvProgramming
{
    class CollectionsDemo3
    {
        static void Main()
        {
            ArrayList al = new ArrayList();
            //Capacity of ArrayList: Capacity means total no.of cells.
            Console.WriteLine("Capacity of ArrayList before adding: "+al.Capacity);//Initial capacity after creating ArrayList is 0
            al.Add(23);
            Console.WriteLine("Capacity of ArrayList after adding 1 int element: " + al.Capacity);//4 (4 empty locations it is going to create)
            al.Add("Lokesh");
            al.Add("Sainath");
            al.Add(73);
            Console.WriteLine("Capacity of ArrayList after adding 3 more elements: " + al.Capacity);//4
            al.Add(199);
            Console.WriteLine("Capacity of ArrayList after adding 1 more element: " + al.Capacity);//8 (4+4)

            al.Add(567.890f);
            al.Add(567.890f);
            al.Add(567.890f);
            Console.WriteLine("Capacity of ArrayList having 8 elements: " + al.Capacity);//8
            al.Add(567.890f);
            Console.WriteLine("Capacity of ArrayList after adding 9th element: " + al.Capacity);//16 (8+8)
            //Size is dynamically increasing.

            al.Remove(23);
            Console.WriteLine("Capacity of ArrayList after Removing 1 element: " + al.Capacity);//16
            al.RemoveRange(0,3);
            Console.WriteLine("Capacity of ArrayList after Removing 3 more elements: " + al.Capacity);//16 (Highest memory allocated that is not changing)

            al.Clear();
            Console.WriteLine("Capacity of ArrayList after clearing its content: " + al.Capacity);//16
            //If you clear also it will be highest capacity what it had previously.


            ArrayList al1 = new ArrayList(10);//Initial capacity of AL is 0. But we can change by specifying default cells
            Console.WriteLine("Capacity of ArrayList-1 which is defined with size 10: " + al1.Capacity);//10

        }
    }
}
