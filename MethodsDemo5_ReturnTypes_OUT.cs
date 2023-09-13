using System;

namespace Lokesh
{
    class MethodsDemo5_ReturnTypes_OUT
    {
        static void Main()
        {
            Test("Lokesh");
            //If the method returning some value. We have to catch or store or print if req. Or directly print in that method itself and make taht as void type.
            string res = Test("Sainath");
            Console.WriteLine(res);
            Console.WriteLine(Test("Gudivada"));

            int x = 10, y = 20;
            Console.WriteLine($"Before Swapping x= {x} y= {y}"); // x = 10 y = 20
            //Swap(x, y);//Call by value/ pass by value: calling a method by passing values of variables
            //only x, y values passed to Swap method and store separate variables (memory locations) a, b which don't have any connectivity to the actual variables.

            Swap(ref x, ref y);//Call by reference/ pass by reference: We are passing x, y memory addresses and a,b act as reference variables which refer to x, y memory locations
            Console.WriteLine($"After Swapping x= {x} y = {y}");
            Calc(x, y , out int c, out int d);
            Console.WriteLine("Calc Sum:" + c);
            Console.WriteLine("Calc Difference:" + d);

            int num1;
            int num2;
            // Call the Add method and pass it as an out parameter.
            Inc(out num1, out num2);
            Console.WriteLine("Num1: {0}", num1);
            Console.WriteLine("Num2: {0}", num2);
        }
        static string Test(string name)
        {
            return ("Hello " + name);
        }
        //A method can take any no.of args
        //A method can return single value [this is a drawback, but it is a feature] Solution is ref & out keywords.
        //A method can return only one time in a call. Callee can have have any no.of return stats in multiple paths, return means return to the caller, control come out of the callee method. It is like break statement in loops. 

        static void Swap(ref int a, ref int b)//a=10 b=20. a,b handle address of arguments.
        {
            int temp = a;// temp=a=10
            a = b;// a = b = 20
            b = temp; //b=temp=10
            // a=20
            // b=10
            //Scope of parameters is within that method only.
        }
        //To return multiple values: Use REF and OUT keywords.
        //The referenced parameters directly point to the actual arguments memory address. So that both formal parameters in the method body can work on actual parameters directly.

        static void Calc(int a, int b, out int c, out int d)//c, d decorated as "out" means these act as return back variables.
        {
            //No separate initialisation is required for c, d.
            c = a + b;
            d = a - b;  
            //a, b act as IN vars or parameters [bring data to the method]. c, d act as OUT variables[Get data from the method to called method]
        }
        //Calculation response we want. We use "out" keyword
        //ref vs out:
        //ref: to get-back the values what ever we are passing to the main program
        //out: out keyword passes arguments by reference only. This is very similar to the ref keyword. OUT doesn't require parameter variables to be initialized before they are passed to a method.
        //If you want result in new variables with out changing the original variables content then OUT keyword. If you want result in the same memory location then REF keyword.
        static void Inc(out int num1, out int num2)//Here out is similar to ref, 
        {
            num1 = 10; num1++;
            num2 = 20; num2++;
        }

        //out keyword can be used with variables and method parameters. The out paramters are always passed by reference for both, the value type and the reference type data types.

        //Caller: a procedure that calls one or more more subsequent procedure(s).
        //Callee: a procedure that is called by another.
    }
}
