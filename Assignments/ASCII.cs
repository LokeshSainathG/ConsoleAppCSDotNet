using System;

namespace Assignments
{
    class ASCII
    {
        static void Main(string[] args)
        {
            //Converting characters to a string:
            char[] letters = { 'A', 'B', 'C' };
            string alphabet = new string(letters);

            string s1 = "Lokesh";
            Console.WriteLine(s1);

            //ASCII operations
            char c1 = 'A';
            Console.WriteLine("Char " + c1);
            int ascii = c1;
            Console.Write("int " + ascii);

            int ascii2 = 65;
            Console.WriteLine("int " + ascii2);
            char x = (char)ascii2;
            Console.Write("Char " + x);

            char c2 = 'A';
            Console.WriteLine(c2 + 1); //66(Since ASCII(A)=65 and 65+1=66).

            int i = 65;
            char ch = (char)i;
            Console.WriteLine(ch);//A
            char ch2 = (Char)i;//A. Type casting.
            Console.WriteLine(ch2);
        }
    }
}