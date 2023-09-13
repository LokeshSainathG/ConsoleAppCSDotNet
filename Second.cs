using System;

namespace Lokesh
{
    class Second
    {
        static void Main()
        {
            //How to define file paths in a string type.
            //string filepath = "C:\Users\netpath\repos\ConsoleAppCSDotNet\Program.cs";
            //Since \ is used for Escape sequences and '\n' Escape sequence is there. This reason it is not throwing error for \n.
            //Solution is:
            string filepath1 = @"C:\Users\netpath\repos\ConsoleAppCSDotNet\Program.cs";//Verbatim literal 
            string filepath2 = "C:\\Users\\netpath\\repos\\ConsoleAppCSDotNet\\Program.cs";//Double back slashes
            string filepath3 = "C:/Users/netpath/repos/ConsoleAppCSDotNet/Program.cs";//Foward slash
            //In ASP.Net core apps, while using Regular expressions, we have to use '@' symbol.
            Console.WriteLine(filepath1);
            Console.WriteLine(filepath2);
            Console.WriteLine(filepath3);//All paths are normal. Even if you use FWD slash also it is valid in Files.
        }
    }
}
