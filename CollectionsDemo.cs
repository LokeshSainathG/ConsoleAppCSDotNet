using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokesh
{
    class CollectionsDemo
    {
        static void Main()
        {
            //Array is a group of homogeneous data type object which is fixed in size and this is strongly typed. Collection is a group of homogeneous and heterogeneous data type object which is not fixed in size and thus is not strongly typed. But we use Generic to make Collection as strong Type (by using namespace System.Collections.Generic).
            //There is process of Boxing and Unboxing on Collection which is not there in Arrays because it is strongly typed.
            //Note: The difference between Array and Collection/ Array and Array list / Array and Data list will be the same.

            //Drawbacks of Arrays:
            //Arrays are fixed in size
            //To insert/ delete an element from middle position, it is difficult.
            //To overcome these problems, we have collections, which is variable in length. Inserting/ deleting in any postion is very easy.

            //Collections:
            //We have to import: using System.Collections.Generic;
            //Collections can have any data type of data.
            //All C lang data structures are Collections in C#
            //ArrayList, HashTable, SortedList, Stack, Queue,... are available collections.

/*Non-generic                       Generic
ArrayList     ------------->        List
HashTable     ------------->        Dictionary
SortedList    ------------->        SortedList  
Stack         ------------->        Stack
Queue         ------------->        Queue
*/
        }
    }
}
