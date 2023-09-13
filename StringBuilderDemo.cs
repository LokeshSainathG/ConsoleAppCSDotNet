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
            //In C#, Strings are immutable, can you define
            string name = "Lokesh";
            name = name + " Sainath";
            name = name + " Gudivada";
            //we are adding data to the string.
            int a = 10;
            a = a + 10;
            a = a + 10;
            Console.WriteLine(a);//30
            Console.WriteLine(name);//Lokesh Sainath Gudivada

            StringBuilder sb = new StringBuilder("Lokesh");
            sb.Append(" Sainath");
            sb.Append(" Gudivada");
            Console.WriteLine(sb); //Lokesh Sainath Gudivada
                                   ////Explanation:////

            //O/P of string and StringBuilder are same. But memory wise there is lot of difference.
            //We know value types (int, char, float) are generally stored in Stack memory. And Reference types (string,) are always stored in Heap memory.
            //Note: Value-types not always stored in Stack. Value types can be stored in the stack when the variable is either a temporary variable or is a local variable.

            //int a; In stack 'a' has value 10 initially and then overrided with 20 and then 30.

            /*string name; In Heap memory, 'name' creates a memory location and store Lokesh & "name" in stack points to Heap location which has data "Lokesh". That's why it is reference type. Address in Heap refer or points to the value in Stack memory.
              When you give (name + " sai") name won't modify existing loc, bcs in C# strings are immutable or non-modifiable and we can't modify that location value. It creates a new location with value "Lokesh Sainath" and points to new loc.
            ///y it creates a one more new loc and store "Lokesh Sainath Gudivada" and name repoints to this loc.
            //When you print 'name'. Whatever address that name points that value stored in that address will be printed.
            */

            /*StringBuilder sb; sb points to a location in Heap memoery which has "Lokesh". When you concatenate " Sai". Compiler override the location with new value and won't create a new memory in Heap.
            So, whenever the string might undergo continuous modifications (string replacing, appending, removing or inserting), we are recommended to use StringBuilder class instead of string.
            Since you can modify its value without creating a new object each time the StringBuilder performs faster than the string if you modify a string value multiple times
            */

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
        //You can pass a value type as a reference to a method by using the ref keyword.
        //[MethodsDemo5_ReturnTypes_OUT.cs]
    }
}
