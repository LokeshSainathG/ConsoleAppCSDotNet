using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokesh
{
    class StringBuilderDemo
    {
        static void Main(string[] args)
        {
            //Diff b/w String & StringBuilder [Interview question]
            //In C#, Strings are immutable and  you can define
            string name = "Lokesh";
            name = name + " Sai";
            name = name + "nath";
            name = name + " Gudivada";
            //we are adding data to the string.
            int a = 10;
            a = a + 10;
            a = a + 10;
            Console.WriteLine(a);//40
            Console.WriteLine(name);//Lokesh Sainath Gudivada

            StringBuilder sb = new StringBuilder("Lokesh");
            sb.Append(" Sai");
            sb.Append("nath");
            sb.Append(" Gudivada");
            Console.WriteLine(sb); //Lokesh Sainath Gudivada
            //o/p of string and StringBuilder are same. But memory wise there is lot of difference.
            //We know value types (int, char, float) are stored in Stack memory. And Refrence types (String,) are always stored in Heap memory.
            //int a; In stack 'a' has value 10 initially and then overrided with 20 and then 30.
            /*String name; In Heap name creates a memory location and store Lokesh & "name" in stack pooints to Heap location which has data "Lokesh".
            when you give (name + " sai") name won't modify existing loc, bcs in C# Strings are immutable and we can't modify that location value. It creates a new location with value "Lokesh Sai" and points to new loc.
            ///y it creates a one more new loc and store "Lokesh Sainath" and name repoints to this loc. ///y "Lokesh Sainath Gudivada".
            */
            /*StringBuilder sb; sb points a location in Heap memoery which has "Lokesh". When you concatenate " Sai". Compiler override the location with new value and won't create a new memory in Heap.
            So, whenever the string might undergo continuous modifications, we are recommended to use StringBuilder class instead of string.*/

            //Logs:
            StringBuilder sb3 = new StringBuilder();
            sb.Append("log something");
            // flush every 20 seconds as you do it
            File.AppendAllText("C:\\log.txt", sb.ToString()); //Appends the specified string to the file, creating the file if it does not already exist.
            //OR you can use @
            File.AppendAllText(@"C:\log1.txt", sb.ToString());
            sb.Clear();

            //OR Another way to add Logs
            //This is add new string in the file:
            using (var file = new System.IO.StreamWriter("C:\\log.txt", true))
            {
                file.WriteLine("log");
                file.Close();
            }
        }
    }
}
