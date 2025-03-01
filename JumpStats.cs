using System;

namespace Lokesh
{
    class JumpStats
    {
        static void Main()
        {
            //3 Jump Stats: goto  break   continue:

            ////////////////////////////////////////////////////////////////////////
            //goto: To switch control from one statement to another using a label. If it switched, it executes from that statement.
            Console.WriteLine("Stat 1");
            goto test;//Label should not be any standard Keyword.
            Console.WriteLine("Stat 2");//This will be skipped bcs of goto.
            test: 
            Console.WriteLine("Stat 3");
            //goto statement might create infinite loops which can't handle by using break stat.
            //goto we can use anywhere. Whereas break, continue should be used with in Looping stats. Of course 'break' stat can be used for Switch stat also (but 'continue' we can't).
            
            ////////////////////////////////////////////////////////////////////////
            //break;
            for (int i=0;i<5;i++)
            {
                if (i == 3)
                    break;
                Console.WriteLine(i);
            }
            Console.WriteLine("break executed.");
            //break is used to terminate a loop (switch also) not the whole program or block. break can be used only in Switch & looping statements to terminate the process early.
            //In the scenario of nested loops, 'break' can be used to come out of that particular loop.
            //If you want to get out of the entire nested loop based on a condition, you can use 'goto'.


            ////////////////////////////////////////////////////////////////////////
            //continue;
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                    continue;
                Console.WriteLine(i);
            }
            Console.WriteLine("break executed.");
            //continue is used to skips the iteration not the whole program/ all iterations. It brings next iteration early. 'continue' can be used only in looping statements.
            //Usecase: I want to give hike all employyes except Contract workers. Before hike logic in the condition check the emp type and continue the iteration.

            //IMP point: In the loop, where you are using break/ continue is important. From that line it is going to break/ continue.
            //break/ continue should be used inside loop (break can be used to break the switch also). inside loop wherever you want you can use (if stat/ else if stat). If loop is having child loop, where you are using inside parent (it breaks that loop)/ child loop (it breaks that loop)

            ///////////////////////////////////////////////////////////////////////////////
            //return;
            //['return' statement terminates or ends callee function execution with or without passing a value to the caller method.]
            //For void functions, which doesn't compute a value, you can use 'return' stat without expression:
            return;//Like this. Since Main() is a void function. You can even omit also for void functions.
            //All the stats after return won't executed, so make sure the condition properly.
            if (true)
            {
                return;
            }
            else
                Console.WriteLine("Operation not succeeded");
        }
    }
}
