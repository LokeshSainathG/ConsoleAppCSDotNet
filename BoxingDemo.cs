using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokesh
{
    class BoxingDemo
    {
        static void Main()
        {
            //We know base type for all the Data types: "Object".
            //Declare a variable as Object type:
            int aa = 100;
            object obj = aa;//Since object is base type for all datatypes, it can hold any type of data (int/ char/ float/ string).
            /*This is known as Boxing - Converting any type to Object type.
             */
            //int bb = obj;//To convert obj type into value type is called as UnBoxing. 
            //For Unboxing, explicit type casting is required.
            int bb = (int)obj;
            //This is not perfect eg for Boxing & Unboxing.
            //We will use this in upcoming concepts (Collections - ArrayList).
        }
    }
}
