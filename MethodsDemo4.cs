using System;

namespace Lokesh
{
    class MethodsDemo4
    {
        static void Main()
        {
            Add(1,2,3,4,5); //Add() can take upto 5 params
            //How to pass any no.of params to the same Add()? We have one more options called params keyword.
            //Using params we can pass no.of parameters to the one function.
            Add2(1,2,3);
            int[] arr = { 1, 2, 3, 4 };
            Add2(arr);//passing Array
            Add2(12, 34, 5);//passing normal args

            udasd(arr:arr);//Rule is optional parameter should be at last. But incase if params list also is there, that list should be at last. In that case since first parameter is optional type. If you are not passing that type, mention the remaining type names. Just like Named args in "MethodsDemo2.cs"
            //With out specifying "null" in parameter list, we can specify null as arg.
            //How to pass variable parameter as Named arg? udasd(s1:"", arr: [23,45,67]);//error
            udasd("", 23,45,67);
            udasd(String.Empty, 34,34,56);
            udasd(null,34,56);
        }
        static void Add(int a, int b, int c = 0, int d = 0, int e = 0)
        {
            Console.WriteLine("Addtion: " + (a + b + c + d + e)); 
        }

        //How Params work: Instead of giving individual parameters. Make integer array as parameter. Array is homogeneous collection. And specify that as "param". So that we can pass normal args& array args.
        static void Add2(params int[] arr)//If you don't specify params, you can't pass normal args to this method. you can only pass Array type. i.e, static void Add2(int[] arr) {} can take array only.
        {
            int sum = 0;
            foreach (int num in arr)
                sum = sum + num;
            Console.WriteLine("Addition: " + sum);
        }
        //Rules for using "params" as a Parameter:
        /*Methods can have only one variable as params type// Add(params int[] arr, params float f1) is invalid.
         *If you are having multiple parameters, params type variable should be at last in order// Add(string s1, ...., params int[] arr)
         *params must be a single dimensional array.
         */
        static void udasd(string s1 = null,params int[] arr)//s1 is optional param (assigned with default value),but since it is first parameter we should pass value to nullable type. one solution is specify the second parameter name (named arguments). another is 
         {
            Console.Write("Passed int Args: ");
            foreach (int num in arr)
                Console.Write("     "+num);
            Console.WriteLine();
        }
    }
}
