using System;

namespace Lokesh
{
    class LoopsDemo
    {
        static void Main()
        {
            //Unlike Selection/ Branching stats, Looping stats execute the block multiple times till the cond is False/ break stat.
            //4 Loop stats - while      do-while    for     for-each
            //We can use while, do-while, for either value type or reference type.
            //But for-each we can use reference type of data.
            //Loop involve initialisation, condition, increment/ decrement
            //Print your name 5 times
            int count=5;
            //////////////////////////////////////////
            //while
            //////////////////////////////////////////
            while (count>=1) //5>=1 4>=1 3>=1 2>=1 1>=1 0>=1
            {
                Console.WriteLine("Lokesh Sainath");
                count--;
            }
            Console.WriteLine("____________________");
            //////////////////////////////////////////
            //do=while
            //////////////////////////////////////////
            count = 1;
            do
            {
                Console.WriteLine("Lokesh Sainath");
                count++;
            }
            while (count <= 5);
            Console.WriteLine("____________________");
            //////////////////////////////////////////
            //for
            //////////////////////////////////////////
            for (count=0;count<5;count++)
            {
                Console.WriteLine("Lokesh Sainath");
            }
            Console.WriteLine("____________________");
        }
    }
}
