using System;

namespace Lokesh
{
    class BoxingDemo
    {
        static void Main()
        {
            //We know base type for all the Data types: "Object". And object is reference type, so it present in the Stack and hold the address where the value stored in Heap memory.
            //https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing
            //Declare a variable as Object type:
            int aa = 100;
            object obj = aa;//Since object is base type for all datatypes, it can hold any type of data (int/ char/ float/ string).
            /*This is known as Boxing - Converting any type to Object type.*/

            //int bb = obj; //To convert obj type into value type is called as UnBoxing. 
            int bb = (int)obj; //For Unboxing, explicit type casting is required.

            //We will use this in upcoming concepts (Collections - ArrayList).
        }

        //Note: Boxing (Value to Reference)
        //Un-Boxing (Reference to Value type). Revealing the value type from reference type called 'object'.
        //The conversion of a value type to a reference type is known as boxing. Unboxing is just the opposite - it is the process of conversion of a reference type to a value type.
    }
}
