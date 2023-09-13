using System;

namespace Lokesh
{
    class MethodsDemo2
    {
        static void Main()
        {
            Console.WriteLine("I am Main()");
            Hello();

            Hi("Lokesh");
            Console.WriteLine("What's your name: ");
            string name = Console.ReadLine();
            Hi(name);//Passing args.
            Test("Lokesh", 11, "Mech");//Passing arguments to the Test in same order as parameters
            //Test("Sainath", "Civil", 12); 
            //We can change the arguments order, that syntax is known as named args.
            Test("Sainath", course: "Civil", age:12);//Named arguments
        }
        static void Hello()//Static Method
        {
            Console.WriteLine("Hello");
        }
        static void Hi(string name)//name is parameter and its scope is within this method
        {
            Console.WriteLine("Hi "+name);
        }
        //A method can take any no.of args.
        static void Test(string name, int age, string course)
        {
            Console.WriteLine($"Hello {name} you are selected for {course} course at the age of {age}");
        }
    }
}
