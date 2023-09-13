using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokesh
{
    class ValueTypesReferenceTypes
    {
        static void Main()
        {
            //////////////////////////////////
            ///ReferenceTypes:
            string a = "abc";
            string b = a;
            a = "def";
            Console.WriteLine(b); //"abc" why?
            //a and b are references to strings. The actual strings involved are "abc" and "def".
            //Initially, both a and b are references to the same string "abc".
            //Later, a is a reference to a new string "def", but we've done nothing to change b, so that is still referencing "abc".

            //////////////////////////////////
            ///ValueTypes:
            int i = 123;
            int j = i;
            i = 456;
            Console.WriteLine(j); //123

            //////////////////////////////////
            ///Comparing references
            //you can compare those references using Object.ReferenceEquals.
            Object.ReferenceEquals(a, b); //true only if they reference the same exact string in memory
            Console.WriteLine(Object.ReferenceEquals(a, b)); //False. Since they are referencing 2 diff strings

            /*
              Variables of reference types store references to their data (objects), while variables of value types directly contain their data.
              Why we need Reference types?
                o	With reference types, two variables can reference the same object; therefore, operations on one variable can affect the object referenced by the other variable.
                o	With value types, each variable has its own copy of the data, and it's not possible for operations on one variable to affect the other (except in the case of in, ref, and out parameter variables; see in, ref, and out parameter modifier).
             */

            ////////////////////////////////////
            ///Pointers: To use Pointers in your source code, it must be inside unsafe block or unsafe function.
            ///Let's understand the concept of Value types using Pointers.
            unsafe
            {
                int* p1 = &i;//int *p1 = &i; is not valid in C#.
                int* p2 = &j;
                Console.WriteLine((int)p1);//13626868
                Console.WriteLine((int)p2);//13626864
            }//unsafe block
        }
        //Unsafe code in C#:
        //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/unsafe-code

        //Error: "Error CS0227  Unsafe code may only appear if compiling with /unsafe"
        //If source code contains the unsafe keyword, then the AllowUnsafeBlocks compiler option must also be used. AllowUnsafeBlocks compiler option allows code that uses the unsafe keyword to compile. The default value for this option is false, meaning unsafe code isn't allowed.
        //Solution: To set the unsafe option in Visual Studio, click on Project in the main menu, Project Properties, select the Build pane, and check the box that says "allow unsafe code."
    }
}
