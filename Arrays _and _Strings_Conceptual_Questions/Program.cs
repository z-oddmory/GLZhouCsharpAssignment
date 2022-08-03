using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays__and__Strings_Conceptual_Questions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.When to use String vs. StringBuilder in C#?
            //If a string is going to remain constant throughout the program, then use String class object because a String object is immutable.
            //If a string can change(example: lots of logic and operations in the construction of the string) then using a StringBuilder is the best option.

            //2. What is the base class for all arrays in C#?
            //The Array class is the base class for all the arrays in C#.

            //3. How do you sort an array in C#?
            //Using Array.Sort method.

            //4.What property of an array object can be used to get the total number of elements in
            //an array?
            //Length Property is used to get the total number of elements in all the dimensions of the Array.

            //5. Can you store multiple data types in System.Array?
            //No, we cannot store multiple datatype in an Array, we can store similar datatype only in an Array.

            //6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?
            //The Clone() method returns a new array object containing all the elements in the original array.
            //This method creates a copy of an array as an object, therefore needs to be cast to the actual array type before it can be used to do very much.
            //The clone is of the same Type as the original Array.

            //The CopyTo() method copies the elements into another existing array.
            //It copies the elements of one array to another pre-existing array starting from a given index(usually 0).
        }


    }
}
