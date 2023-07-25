using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokesh
{
    class JumpStats
    {
        static void Main()
        {
            //3 Jump Stats: goto  break   continue
            //goto: To make control from one statement to another
            Console.WriteLine("Stat 1");
            goto test;//Label should not be any standard Keyword.
            Console.WriteLine("Stat 2");
            test: Console.WriteLine("Stat 3");
            //goto statement might create infinite loops which can't handle by using break stat.
            

            //break;
            for (int i=0;i<5;i++)
            {
                if (i == 3)
                    break;
                Console.WriteLine(i);
            }
            Console.WriteLine("break executed.");
            //break is used to terminate the process not the whole program. break can be used only in Switch & looping statements.

            //continue
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                    continue;
                Console.WriteLine(i);
            }
            Console.WriteLine("break executed.");
            //continue is used to skips the iteration not the whole program/ all iterations. continue can be used only in looping statements.
            //Usecase: I want to give hike all employyes except Contract workers. Before hike logic in the condition check the emp type and continue the iteration.

            //IMP point: In the loop, where you are using break/ continue is important. From that line it is going to break/ continue.
            //break/ continue should be used inside loop (break can be used to break the switch also). inside loop wherever you want you can use (if stat/ else if stat). If loop is having child loop, where you are using inside parent (it breaks that loop)/ child loop (it breaks that loop)
        }
    }
}
