using System;

namespace Lokesh
{
    //An enum is defined using the enum keyword, directly inside a namespace, class, or structure.
    //enum is a special "class" that represents a group of constants (unchangeable variables, like final variables).
    //enumeration is a complete, ordered listing of all the items in a collection. The term is commonly used in mathematics and computer science to refer to a listing of all of the elements of a set.
    //Best way to define the enum is to declare it in a separate file or header file. So, that you can use it anywhere you want by including that header file during compilation.
    enum Gender//enum is going to define a type.
    {
        Male, Female, male, female //Purpose of enum is to create String Constants separted by comma. //Starting value is 1.
        //You can't use any other data for this enum type. The variable of this enum should be any one of these collection.
    }
    enum AccountType
    {
        Saving =5, Current, Joint //Starting value is 5.
    }
    enum EmpType
    {
        Perm=10, Temp=7, Hourly=11//Each string constant having separate numeric values
        //Perm = 10, Temp, Hourly = 11 //Temp - 11. So both Temp, Hourly also 11
    }
    class EnumDemo //class name should not be key words (while, for, class, Main, if)/ namespace/ 
    {
        static void Main()
        {
            //Every datatype has a separate way of representation and can store specific type of data.
            int a = 40; //In int var, we can store only numeric type of data either +ve / -ve int. It can't hold decimal val, string val.
            //a is strongly typed which can take only int type of data. ///y string can only take data in "". even character also it can't data in 'x' it can't take.
            //I want to store GENDER in a string. Male/ Female.
            //string gen = "Male"/ "iefnifidniwdis"
            //How to restrict to store only Male/ Female in g. How? Using enums.

            //Gender g = "Female";//It is worng notation. How int, string, char are restricting the data. ///y gen variable is of Gender type and can have some set of data only.
            //"" is string representation, '' is char representation. For enum representation, we use <enum-name>.data.
            Gender gen = Gender.Female;
            //Other than Male, Female. We can't give any other value.
            //How to say this Gender is an enum. After writing Gender, we are getting some values.
            //And the enum data having some initial values. Default start with 0.
            Console.WriteLine("Selected Gender: "+gen);
            //If you want to store this data in DB, to compare Male/ Female. String comparision is little clumsy & numeric comparision is easy. To fetch the numeric value associated with the enum we can type cast.
            Console.WriteLine("Selected Gender: " + (int)gen); //Display purpose we use string and storing purpose we hold int value
            AccountType acc = AccountType.Current;
            Console.WriteLine("Selected Acc type: " + acc); 
            Console.WriteLine("Selected Acc type: " + (int)acc);//6
            //variables a, gen are  having local scope (main() variables)
        }
        //By using enums we can maintain the code properly. When some thing is required to add in future, we can add that in enum collection, and modify other areas accordingly.
    }
}
