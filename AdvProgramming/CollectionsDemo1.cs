using System;
//using System.Collections.Generic; //Generic collections [Type saftey]
using System.Collections;//Collections


namespace AdvProgramming
{
    class CollectionsDemo1
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
            //Collections are variable length.
            //Collections can have any data type of data.
            //inserting/ deleting an element at any position is easy.
            //We have to import a Namespace: using System.Collections.Generic;
            //All C lang Data structures are can be implemented using Collections in C#
            //ArrayList, HashTable, SortedList, Stack, Queue,... are available collections.

            /*Non-generic                       Generic
            ArrayList     ------------->        List
            HashTable     ------------->        Dictionary
            SortedList    ------------->        SortedList  
            Stack         ------------->        Stack
            Queue         ------------->        Queue
            */
            /*System.Collections.Generic; For Generic type [type saftey]
            * System.Collections; For Non-generic type
            */
            ArrayList al = new ArrayList(); //Import System.Collections; namespace
            //ArrayList is predefined class. we need to create an object al the the ArrayList class to use the methods defined in ArrayList.
            al.Add(23);//It is taking elements as object type. Since Object is base type for all data types we can store any kind of data.
            al.Add(673.65f);
            al.Add("Lokesh ");
            al.Add('G');
            //ArrayList is Index based like Array.
            //Data fetching:
            foreach(var item in al)//Since ArrayList store elements in obj type, we use "var" based on the type of data, the type is going to define.
                Console.Write(item + "     ");Console.WriteLine();

                            ArrayList al1 = new ArrayList();
                            al1.Add("Sony");
                            al1.Add("Lenovo");
            
            //To add multiple elements:
            al.AddRange(al1);//Adds the al1 data to al at last
            foreach (var item in al)
                Console.Write(item + "     ");Console.WriteLine();
            //To Insert at specific Index
            al.Insert(3, "Micromax");
            al.InsertRange(0, al1);
            foreach (var item in al)//we use "var" based on the type of data, the type is going to define.
                Console.Write(item + "     ");Console.WriteLine();

            //To remove:
            al.Remove("Sony");//First instance of "Sony" is removed
            al.RemoveAt(2);
            al.RemoveRange(0,3);
            foreach (var item in al)//based on the type of data, type is going to define
                Console.Write(item + "     ");Console.WriteLine();
        }
        //Add(): To add single element in obj type at last pos
        //AddRange(): To add multiple elements in collection type at last pos
        //Insert(): To insert an element of obj type at specified index
        //InsertRange(): To insert range of elements of Collection type at specified index
        //Remove(): To Remove an object
        //RemoveAt(): To Remove an object by specifying its index
        //RemoveRange(): To Remove range of elments - start index, count
        //Clear(): Clears ArrayList.
    }
}

