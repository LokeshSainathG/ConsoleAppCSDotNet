using System;

namespace Lokesh
{
    class ArraysTwoDim
    {
        static void Main()
        {
            //In 1D, we represent only no.of columns. In 2D, we represent both no.of columns and no.of Rows.
            int[,] arr;//Specify ',' then it is 2D Array.[IMP] In C/ C++/ Java, we specify arr[][] for 2D array. But this notation is used for Jaged Array.
            Console.WriteLine("Enter no.of Rows, Columns: ");
            int r = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            arr = new int[r, c];
            //To represent element, first specify Row index, then Column index
            //2D is Matrix representation.
            //For 2*3 Matrix: if i=0, j can be 0,1,2[First row Elements]. if i=1, j can be 0,1,2[Second Row elements]. 2D Array is collection of 1D arrays (can be 2 rows/ 3 rows ...)
            Console.WriteLine("Enter Elements:");
            for(int i=0;i<r;i++)//Row
                for (int j = 0; j < c; j++)//Column
                    arr[i,j]=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Elements of the Table:");
            for (int i = 0; i < r; i++)
            { 
                for (int j = 0; j < c; j++)
                    Console.Write(arr[i,j]+"    ");
                Console.WriteLine();
            }
        }
    }
}
