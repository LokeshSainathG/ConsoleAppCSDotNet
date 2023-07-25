using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokesh
{
    class MethodsDemo3
    {
        static void Main()
        {
            //when we are witing Console.WriteLine/ Convert.ToInt32/ Convert.ToInt64, it is showing 1 of 19 overloaded syntaxes.
            //Console.WriteLine();Console.WriteLine(char value); Console.WriteLine(char[] buffer).......
            //Method Overloading: In a class morethan 1 method having same method name, but differ in parameters type/ number of parameters/ order of parameters.
            //Calculator: Using + symbol we can add int values/ decimal values (float(32-bit precision)/ double(64-bit precision)/ decimal(128-bit precision)). Internally it is calling different methods.
            //Console.WriteLine(); MethodAccessException highlights the respective overloaded method once we provide the variable among the 19 overloaded methods.

            //Because of method overloading, only one WriteLine() able to print different types of data on console.
            //We can create 4 Add methods which add 2, 3, 4, 5 numbers. Only difference no.of integers it is adding. But that is more complex
            //To avoid such things and writing these many methods: we have the concept called Optional Parameters
            //Optional Parameters: Assign initial values to the optional parameters in function definition.
            Add(12, 34);//Add method is ready to take 2 params/ 2/ 4/ 5 parameters.
            Add(12, 45, 67);//c=0 value is replaced by 67
            Add(1, 4, 5, 2, 3);
        }
        static void Add(int a, int b, int c=0, int d = 0, int e = 0)//a&b are mandatory parameters for Addition. Rest if you pass args it will consider.
        {
            Console.WriteLine("Addtion: " + (a + b + c + d + e)); //Since 0+anything is Zero. So, No issues.
        }//Assign initial values whatever you want. But that won't affect the Function outcome.
        
    }
}
