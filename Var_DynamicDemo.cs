using System;

namespace Lokesh
{
    class Var_DynamicDemo
    {
        static void Main(string[] args)
        {
            //When you declare a var of int type. we are storing integer type of data. ///y We store string type in String var.
            //[Interview Question]
            //By using "var" we can store any kind of data. To store result of a lengthy formaula. Based on the result the var is gooing to define the type.
            //If you are defining a variable with var, we need to initialise immediately. We can directly store the result of a formula.
            //'dynamic' is used to avoid the compile-time type checking. 

            var i = 2;
            Console.WriteLine(i.GetType());
            //i = 1.2f; //Here i behave like int.
            var s = "hi";
            //s = 1; //Here s behave like string

            //var is going to define its type at compile time. if you are declaring a variable as var, we have to immediately initialise value.
            //once its type was defined, we can't assign another type of explicit data like in Python.
            var d = 1.2;
            d = 1;
            float f2 = 1.2f;
            f2 = 4;

            ///////////////////////////////////////////////////////////////////////////////////////////////////
            //Where GetType() method defined? In float struct/ int struct we have only GetTypeCode() enum. But where GetType() is? 
            //object is base type for all data types. That is (value types [Simple (int, float, char, bool), enum, struct, nullable] & Reference types[class, Interface, Array, Delegate])
            //If you go to "Object" definition, you can see GetType().
            //When you sat <var_name>.GetType(). It means "object_name.Method_name()". The methods can be from that type (int) which is a structure or parent type (Object) class.
            //https://www.geeksforgeeks.org/difference-between-class-and-structure-in-c-sharp/
            //[structs are generally faster than classes.]
            //A structure type can't inherit from other class or structure type and it can't be the base of a class. However, a structure type can implement interfaces. 
            int a = 0; object b = 23;
            Console.WriteLine("Type of 'a': "+a.GetType()+"\t"+ "Type of 'b': "+b.GetType());
            b = (int)b + 1;//Casting to original type is required to use object types & perform operations on them
            Console.WriteLine("After incrementing b: " + b);
            Console.WriteLine(sizeof(Int32)); //4
            Console.WriteLine(int.MinValue+"  to  "+int.MaxValue); //4. Actually in Int32 structure itself these are defined as const values.
            Console.WriteLine(sizeof(Int32)); //4


            /*similarly we have dynamic, its type is defined at run-time.
             for dynamic variables, its type is going to define its type based on the last value assigned value for the dynamic variable.
            */
            dynamic result;
            result = 10;
            Console.WriteLine(result.GetType());
            result = "Lokesh";
            Console.WriteLine(result.GetType());
            //dynamic variable is similar to var in Python.

            //result = result * 10; //At run time it through error.
            //var v = "Lokesh";
            //v = v * 10; //At compile time it through error.
            //So, while using dynamic we should take care of run time execution.

            //There are some problems with dynamics too:
            //Since it does n't evaluate at compile-time, we should overcome the run time executions. 
            //https://dev.to/anthonytr/why-you-shouldnt-use-the-dynamic-type-in-net-3hk6#:~:text=Just%20like%20the%20Async%20keyword,JS%20in%20your%20C%23%20code.
        }
    }
}
