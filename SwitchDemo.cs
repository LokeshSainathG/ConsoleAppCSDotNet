using System;

namespace Lokesh
{
    class SwitchDemo
    {
        static void Main()
        {
            // read color code (rgb) and print color name
            Console.WriteLine("Select any color code (PGB) : "); 
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'r' || ch == 'R')
                Console.WriteLine("You are selected Red");
            else
                if (ch == 'g' || ch == 'G')
                Console.WriteLine("You are selected Green");
            else
                if (ch == 'b' || ch == 'B')
                Console.WriteLine("You are selected Blue");
            else
                Console.WriteLine("Invalid color code!");
            //Problem here is that it is checking each condidtion. What if we have 30 conditions and condition might satisfy at 30th cond? 
            //It is not recommended.
            switch(ch)
            {
                case 'r':
                case 'R': Console.WriteLine("Red"); break;
                case 'g':
                case 'G': Console.WriteLine("You are selected Green"); break;
                case 'b':
                case 'B': Console.WriteLine("You are selected Blue"); break;
                default:
                    Console.WriteLine("Invalid color code!"); break; //default switch in C# require break. In C# we can have case after default. To avoid forgetten break mistake, in C# it is mandatory to have break for default case.
                //Compared to Multiple if. Switch improves the performance. But condition we are validating in Multiple if, we can't give in Switch.
                //When you are checking choices, we use switch.
            }

        }
    }
}
