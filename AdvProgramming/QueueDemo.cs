using System;
using System.Collections;

namespace AdvProgramming
{
    class QueueDemo
    {
        static void Main()
        {
            //Queue: FIFO - First-in First-out. Insert & Delete operations are called Enqueue & Dequeue
            Queue qu = new Queue();
            qu.Enqueue(23);
            qu.Enqueue(234);
            qu.Enqueue(345);
            qu.Enqueue(456);
            //for(int i=0;i<qu.Count;i++)
            foreach (var item in qu) 
                Console.WriteLine(item);
            Console.WriteLine("Deleted Element: "+ qu.Dequeue());
            //We can't delete/ insert in middle of Stack/ Queue. We can't pass any args like index or element while deleting.

            //With this we completed Collections (Non-Generic)
            //Generic Collections we discuss in OOPS concepts discussion.
        }
    }
}