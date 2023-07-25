using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokesh
{
    class MethodsDemo
    {
        static void Main()//static method
        {
            //So far we have one method called Main() which is entry point for the project.
            //Instead of writting huge code divide into blocks based on the functionality and we put in a block called method.
            //1.It makes easy to maintain the code. 2.we can reuse it if req.
            Console.WriteLine("I am Main()");
            Hello();
            //A static method can call another static method directly.
            //Hi();
            //A static method can another normal method by creating an object of that class where that normal method is defined. 
            MethodsDemo obj = new MethodsDemo();
            obj.Hi();
        }
        //To write a Method:
        //You can write method anywhere, but where you are calling method is Important.
        static void Hello()//Static Method
        {
            Console.WriteLine("Hello");
        }
        void Hi()//Normal Method
        {
            Console.WriteLine("Hi");
        }
    }
}
