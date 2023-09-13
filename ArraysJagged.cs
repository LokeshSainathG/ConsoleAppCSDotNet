using System;

namespace Lokesh
{
    class ArraysJagged
    {
        static void Main()
        {
            //In 1D: 1 Row& Mulitple columns
            //In 2D: Multiple Rows & Multiple Columns
            //In Jagged Arrays:Array of Arrays. Memory representation is we specify only no.of Rows. Each row has their own size of another Array.
            //Like 1 Row may have 2 columns, 1 can have 1 column, 1 can have 10 columns.
            int[][] arr;//2 separate brackets.
            Console.WriteLine("Enter no.of Rows for Jagged Array: ");
            int r = Convert.ToInt32(Console.ReadLine());
            arr = new int[r][]; //No bothering for columns. This is Jagged Array representation. Since each row can have specific no.of cells.
            for (int i = 0; i < r; i++)
            {
                Console.WriteLine("Enter no.of elements for {0} row: ", i + 1);
                int cols = Convert.ToInt32(Console.ReadLine());
                arr[i] = new int[cols];//Each Row will act as a separate Array. And arr[i] 'each Row' will point to the corresponding array arr[cols] in each iteration.
            }
            //--------Construction of Jagged Array-------
            for (int i = 0; i < r; i++)
            {
                Console.WriteLine("Enter {0} elements in {1} Row: ", arr[i].Length, i + 1);
                for (int j = 0; j < arr[i].Length; j++)
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements of the Jagged Array:");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                    Console.Write(arr[i][j] + "    ");
                Console.WriteLine();
            }
            //Prefer Jagged Arrays over Multi Dimensional Arrays.
            //We use Collections over Arrays mostly in C# Programming.
        }
    }
}
