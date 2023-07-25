using System;

namespace Lokesh
{
    class ConstantsDemo
    {
        static void Main(string[] args)
        {
            //Variable is a temp storage location which can hold values. We can change var value through out the program.
            int a = 100; //a is variable which has local scope. we can access with in main().
            //We can use initialised variable / which take value from user at run time by using ReadLine(). But we can't use uninitialised variable.
            int b = Convert.ToInt32(Console.ReadLine());
            int c;
            Console.WriteLine(a);
            Console.WriteLine(b);
            //          Console.WriteLine(c); //Not valid

            //Constants helps to make variables as constant and can't undergo any changes.
            const int k = 100;//we can't change assigned values for constants. We can use these for scientific constants. Domain related variables which are same across project.
            //LHS of an assignment must be a var, property or indexer. It can't be constant
            //k = k + 10;

            int i = 10;
            long l = 1000L;//If you specify value as l, it consider it as Long. Otherwise it take that as int.
            float f = 99.2f;//If you specify value as f, it consider it as single float. Otherwise it take that as double.
            decimal d = 14.4m;//If you specify value as m, it consider it as decimal. Otherwise it take that as double.



        }
    }
}
