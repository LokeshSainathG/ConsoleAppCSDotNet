using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokesh
{
    class ArraysDemo
    {
        static void Main()
        {
            //Arrays are used to store homogeneous type of data in contiguous memory locations.
            //Types: 1D (Linear)    2D (Tabular/ Matrix)    3D ... Multi dimensional, Jagged Arrays (Array of Arrays)
            //Arrays is allocated on the Heap.
            /*The stack is faster because the access pattern makes it trivial to allocate and deallocate memory from it (a pointer/integer is simply incremented or decremented), while the heap has much more complex bookkeeping involved in an allocation or free.
             * Stack memory size is very less when compared to Heap memory. Because of simplicity in memory allocation (LIFO), stack memory is very fast when compared to heap memory.
             */
            //Prefer Jagged Arrays over multi-dim arrays. Jagged array helps in Memory Management. In a multidimensional array, each element in each dimension has the same, fixed size as the other elements in that dimension. In a jagged array, which is an array of arrays, each inner array can be of a different size. By only using the space that's needed for a given array, no space is wasted.

            //To create single dimensional array, you need to use square brackets [] after the type.
            //In C, we can specify Array size at compile time. But, in C# we can specify Array size at Run time. Then Memory allocation also done at Runtime. By using a "new" keyword we specify size.
            //Other than Arrays, we have another concept called Collections. In collections no need of using new keyword.

            //in Single dimension arrays - we have 1 Row and no.of columns. Array index always starts with 0
            int a = 10;//int var
            Console.WriteLine("Enter a number:"); 
            int aa = Convert.ToInt32(Console.ReadLine());//Run time

            int[] arr= { 10,20,30};//Single dim int array var. At compile time we are specifying size of Array.
            int[] arr2;
            Console.WriteLine("Enter no.of elements: ");
            int count= Convert.ToInt32(Console.ReadLine());
            arr2 = new int[count];//Run time
            //With the help of new keyword we allocated Memory for this Array. Because of this reason Arrays comes under Refrence type of category.
            Console.WriteLine("Enter the {0} elements", count);
            for(int i=0;i<count;i++)
                arr2[i]= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nArray Elements: ");
            for (int i = 0; i < count; i++)
                Console.Write(arr2[i]+"   ");
            Console.WriteLine();
            //foreach loop: Generally foreach is used with Reference type of data.
            Console.WriteLine("arr Array Elements");
            foreach (int item in arr)
                Console.Write(item + "   ");
            //foreach doesn't require initialisation, updation. It automatically traverse the Reference untill it got Null value. Once NULL identified it terminates the foreach loop.
            //In value type of data we can't store NULL. That's reason foreach is not recommended for Value types.
            /*All fundamental data types, Boolean, Date, structs, and enums are examples of value types. Examples of reference types include: strings, arrays, objects of classes, etc. 
             * To create reference types in C#, you can take advantage of these keywords: class, interface and delegate.
            Value Type:
            In value type, the data value is stored in its own memory address. Eg int i= 500.
            Examples of value types are  structure, int, char, bool, decimal, etc.
            Reference Type:
            In reference type, it stores points of the memory location where the data values are stored.
            Eg. string str = “Hello Kirtesh”
            An example of a reference type is a class.
            https://www.c-sharpcorner.com/article/c-sharp-understand-equality-for-value-type-and-reference-type/*/
            //In C lang, we have many Array programs like Linear search, Binary search, sort, reverse, copy.
            //In C#, MS had given all these in the form of methods. These are avialable in Array class in System library.
            Array.Reverse(arr2);
            Console.WriteLine("\nAfter Reversing");
            foreach (int item in arr2)
                Console.Write(item + "   ");
            Array.Sort(arr2);
            Console.WriteLine("\nAfter Sorting");
            foreach (int item in arr2)
                Console.Write(item + "   ");
        }
    }
}
