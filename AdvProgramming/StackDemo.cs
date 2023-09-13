using System;
using System.Collections;

namespace AdvProgramming
{
    class StackDemo
    {
        static void Main()
        {
            //Stack: LIFO - Last-in First-out. Insert & Delete operations are called Push & Pop.
            Stack st = new Stack();//Data will be obj type
            st.Push(56);
            st.Push(233.46f);
            st.Push("Lokesh");
            foreach (var item in st)
                Console.WriteLine(item);//Fetching elements also from Last.
            Console.WriteLine("Popped Element: "+st.Pop());//No args required. Deletes Last element automatically. It returns the Obj, so you can catch removed element

            //for(int i=0;i<st.Count;i++)
            foreach (var item in st)
                Console.WriteLine(item);

        }
    }
}
