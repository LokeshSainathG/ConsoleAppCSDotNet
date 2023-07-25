using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokesh
{
    //An enum is defined using the enum keyword, directly inside a namespace, class, or structure.
    //Best way to define the enum is to declare it in header file. So, that you can use it anywhere you want by including that header file during compilation.
    enum Gender//enum is going to define a type.
    {
        Male, Female, male, female //Purpose of enum is to create String Constants separted by comma. //Starting value is 1.
    }
    enum AccountType
    {
        Saving =5, Current, Joint //Starting value is 5.
    }
    enum EmpType
    {
        Perm=10, Temp=7, Hourly=11//Each string constant having separate numeric values
        //Perm = 10, Temp, Hourly = 11//Temp - 11 & Hourly also 11
    }
    class EnumDemo //class name should not be key words (while, for, class, Main, if)/ namespace/ 
    {
        static void Main()
        {
            int a = 40; //In int var, we can store only numeric type of data either +ve / -ve int. It can't hold decimal val, string val.
            //a is strongly typed which can take only int type of data. ///y string can only take data in "". even character also it can't data in 'x' it can't take.
            //I want to store GENDER in a string. Male/ Female.
            //string gen = "Male"/ "iefnifidniwdis"
            //How to restrict to store only Male/ Female in g. How? Using enums.
            //
            Gender gen = Gender.Female ;//How int, string, char are there. ///y gen variable is of Gender type.
            //"" is string representation, '' is char representation. For enum representation, we use <enum-name>.data. 
            //Other than Male, Female. We can't give any other value.
            //How to say this Gender is an enum. After writing Gender, we are getting some values.
            //And the enum data having some initial values. Default start with 0.
            Console.WriteLine("Selected Gender: "+gen);
            //If you want to store this data in DB, to copare Male/ Female. String comparision is little clumsy & numeric comparision is easy. To fetch the numeric value associated with the enum we can type cast.
            Console.WriteLine("Selected Gender: " + (int)gen); //Display purpose we use string and storing purpose we hold int value
            AccountType acc = AccountType.Current;
            Console.WriteLine("Selected Acc type: " + acc); 
            Console.WriteLine("Selected Acc type: " + (int)acc);//6
            //variables a, gen are  having local scope (main() variables)
        }
    }
}
