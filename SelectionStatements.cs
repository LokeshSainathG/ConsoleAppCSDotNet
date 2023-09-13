using System;

namespace Lokesh
{
    class SelectionStatements
    {
        static void Main()
        {
            //Selection Statements are used to check condition, if it cond is true, it executes a block of stats. If it is false, it executes another set of stats.
            //Whether cond id T/ F, it executes the respective block only once.
            //if, switch are selection stats and ternary operator (?:) also looks like Selection statements. But it is an operator.
            //Simple if - if(cond){} else {}
            //Nested if - if(cond){if(cond){}} 
            //Multiple if - if(cond){} else {if(cond){}} else{if(cond){}} | if(){} else if(){} else if(){} else{}

            // read 5 subjects marks and cal tot, avg, grade if the student passed in all subjects
            // m1, m2, m3, m4, m5 -Local Scope
            Console.WriteLine("Enter 5 subjects marks");
            int m1 = Convert.ToInt32(Console.ReadLine());
            int m2 = Convert.ToInt32(Console.ReadLine());
            int m3 = Convert.ToInt32(Console.ReadLine());
            int m4 = Convert.ToInt32(Console.ReadLine());
            int m5 = Convert.ToInt32(Console.ReadLine());
            if (m1 >= 35 && m2 >= 35 && m3 >= 35 && m4 >= 35 && m5 >= 35)
            {
                // tot, avg is called as block scope (block variables)
                int tot = m1 + m2 + m3 + m4 + m5;
                float avg = (float)tot / 5;// type cast tot as float. Otherwise, you will get Integer value only. When you are doing division, either Numerator/ Denominator should be float, otherwise result will be integer.
                Console.WriteLine($"Total = {tot} \nAverage {avg}");//String Interpolation to print multiple expressions as single string "".
                if (avg >= 80)//Nested if - if inside another if
                    Console.WriteLine("Grade = A");
                else //Multiple if
                    if (avg < 80 && avg >= 60)
                    Console.WriteLine("Grade = B");
                else
                    if (avg < 60 && avg > 40)
                    Console.WriteLine("Grade = C");
                else 
                    Console.WriteLine("Grade = D");
            }
            else
            {
                Console.WriteLine("Sorry");
            }
            /*2 kinds of Type casting:
             * Implicit & Explicit
             * Implicit type casting
             */
            int a = 100;
            long b = a; //Implicit. Storing 4 bytes of value in 8 bytes of variable. Compiler automatically do this casting implicitly.
            float f = 1.2f;
            double d = f;//Implicit

            //Explicit:
            short s = (short)a;//2 bytes of variable = 4 bytes of variable value. compiler can cast lower variable to higher variable. 
            //To specify explicit type casting: specify the data type left hand side of variable. converting int variable into short type.
            //Explicit type casting useful in many scenarios. Like 2 integers division is an int, which is not accurate. We can type cast into (float) to get actual decimal value.
        }
    }
}