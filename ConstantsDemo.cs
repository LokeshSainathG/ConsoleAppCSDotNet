using System;

namespace Lokesh
{
    class ConstantsDemo
    {
        static void Main(string[] args)
        {
            //Variable is a temp storage location which can hold values. We can change var value through out the program.
            int a = 100; //a is variable which has local scope. means we can access with in main().
            //We can use initialised variable / which take value from user at run time by using ReadLine(). But we can't use uninitialised variable.
            int b = Convert.ToInt32(Console.ReadLine());
            int c;
            Console.WriteLine(a);
            Console.WriteLine(b);
            //Console.WriteLine(c); //Not valid. With out initialization of declared variable either at run time or statically, you can't access or use it.

            //Constants helps to make variables as constant and can't undergo any changes.
            const int k = 100;//we can't change assigned values for constants. We can use these for scientific constants. Domain related variables which are same across project.
            //LHS of an assignment must be a var, property or indexer. Then only you can change. If it is const you can't.
            //k = k + 10;//It won't allow.


//Variable value can change. But const value can't.

            //Diff b/w const & readonly: [Interview Question]
            //This we will see in OOPS concept.
            //If you define any var as const, you should initialize it or immediately you have to assign.
            const float pi = 3.14f;


            int i = 10;//10 (Integers) is treated as INT type of data by default.
            long l = 1000L;//If you specify value as l, it consider it as Long. Otherwise it take that as int. Remove suffix 'L' or 'l', and hover mouse on the value 1000. It shows Int32 type. 

            double d = 14.23; //OR 14.23d;
                              //By default, the decimal numbers are treated as double. So we need to specify 'f' or 'm' for float, decimal respectively.
            float f = 99.2f;//If you specify value as f, it consider it as single float (single precision). Otherwise it take that as double. (double precision)
            decimal dd = 14.4m;//If you specify value as m, it consider it as decimal. Otherwise it take that as double.


            ////////////////////////////////////////////////////////////////////
            //Precision is the main difference b/w float, double, decimal.
            ////////////////////////////////////////////////////////////////////
            float flt = 1F / 3;
            double dbl = 1D / 3;
            decimal dcm = 1M / 3;
            Console.WriteLine("float: {0} double: {1} decimal: {2}", flt, dbl, dcm);
                      /*OUTPUT:
                        float: 0.3333333
                        double: 0.333333333333333
                        decimal: 0.3333333333333333333333333333*/ 
                      //Precision: f - 7, d - 15, m = 28 digits
            //Decimals are much slower (up to 20X times in some tests) than a double/float.
            //Use decimal for counted values [money]
            //Use float/double for measured values [distance, length, etc.,]
            //Note:
            //always use overflow checking for Decimal (System.Decimal). Where as for float, double not required.
            decimal max = decimal.MaxValue;
            Console.WriteLine(max);//79228162514264337593543950335
            //max += 1;//Causes Overflow exception
            Console.WriteLine(max);
            //Same won't happen with float, double.

            DateTime dob = new DateTime(1999, 12, 19); //default format: (yyyy, mm, dd)
            //DateTime dob2 = new DateTime(1999 / 12 / 19);Not valid format
            Console.WriteLine(dob + "\t");
        }
    }
}
