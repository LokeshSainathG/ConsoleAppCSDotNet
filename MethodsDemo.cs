using System;

namespace Lokesh
{
    class MethodsDemo
    {
        //So far we have one method called Main() which is entry point for the project.
        //Instead of writting huge code divide into blocks based on the functionality and we put in a block called method.
        //1.It makes easy to maintain the code. 2.we can reuse it if req which avoid code repetition or Redundancy.

        //To write a Method:
        //You can write method anywhere, but where you are calling method is Important.
        static void Hello()//Static Method
        {
            Console.WriteLine("Hello");
        }
        void Hi()//Normal (instance) Method
        {
            Console.WriteLine("Hi");
        }
        static void Main(string[] args)//static method
        {
            Console.WriteLine("I am Main()");
            Hello();
            //A static method can be called another static method directly it is also inside the same class.
            //Hi();
            //A static method can call another normal method or instance method by creating an object of that class where that normal method is defined. 
            MethodsDemo obj = new MethodsDemo();
            obj.Hi();
        }
    }
}
