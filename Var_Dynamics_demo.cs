using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokesh
{
    class Var_Dynamics_demo
    {
        static void Main(string[] args)
        {
            //When you declae a var of int type. we are storing integer type of data. ///y We store string type in String var.
            //[Interview Question]
            //By using "var" we can store any kind of data. To store result of a lengthy formaula. Based on the result the var is gooing to define the type.
            //If you are defining a variable with var, we need to initialise immediately. We can directly store the result of a formula.
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
            //Where GetType() method defined? In float struct/ int struct we have only GetTypeCode() enum. But where GetType() is 
            //Object is base type for all data types. That is (value types [Simple (int, float, char, bool), enum, struct, nullable] & Reference types[class, Interface, Array, Delegate])
            //If you go to "Object" definition, you can see GetType().
            int a = 0;
            Console.WriteLine(a.GetType());
            Console.WriteLine(sizeof(Int32)); //4
            Console.WriteLine(int.MinValue+"  to  "+int.MaxValue); //4
            Console.WriteLine(sizeof(Int32)); //4


            /*similarly we have dynamic, its type is defined at run-time.
             for dynamic variables, its type is going to define its type based on the last value assining to the dynamic variable.
            */
            dynamic result;
            result = 10;
            Console.WriteLine(result.GetType());
            result = "Lokesh";
            Console.WriteLine(result.GetType());
            //dynamc variable is similar to var in Python.

            //result = result * 10; //At run time it through error.
            //var v = "Lokesh";
            //v = v * 10; //At compile time it through error.
            //So, while using dynamic we should take care of run time execution.
        }
    }
}
