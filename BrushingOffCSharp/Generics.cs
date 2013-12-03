using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushingOffCSharp
{
    class Generics
    {
        public void mainForGenerics()
        {
            // Arrays are storngly typed. That means in an int type array one cannot add string type value.
            // This way we dont run in to a run-time error, as we are forced to correctly type it and throws a compile time error.
            // But arrays has limitations as well, e.g. fixed size, if we try to add extra value to an array, it will not catch it in the compile time but will throw a runtime exception.

            int[] num = new int[3];
            num[0] = 101;
            num[1] = 102;
            //num[2] = "Apple"; //this is not possible. Throws a compile time error. Hence type safe, doesnt let problem go to the run time.


            //Collections, e.g. ArrayList on the other hand are not type safe, but is far more flexible than arrays. Size changes automatically.
            ArrayList Numbers = new ArrayList(3);
            Numbers.Add(101);
            Numbers.Add(102);
            Numbers.Add(103);
            //Numbers.Add("Apple"); // This how ever is not caught during compile time, hence not type safe and will create a run time error.


            // GENERICS
            /// Generics are type safe like arrays.
            /// Can grow automatically in size like collections/ArrayLists
            /// Are Convinient to work with using methods like Add, Remove etc.
            /// 

            /// Generic Collection ============================================= Non Generic Collection
            /// System.Collections.Generic ===================================== System.Collections
            /// List<T> ======================================================== ArrayList
            /// Dictionary<Tkey,Tvalue> ======================================== HashTable
            /// Stack<T> ======================================================= Stack
            /// Queue<T> ======================================================= Queue
            /// Where T is the type.
            /// 

            /// We can also make interface and delegates generic.

            /// Generics allows us to design classes and methods decoupled from the data types.
            /// 

            List<int> numbo = new List<int>(3);

            numbo.Add(101);
            numbo.Add(102);
            numbo.Add(103);
            //numbo.Add("Apple"); // Throws a compile time error, hence strongly typed.  
            numbo.Add(104);

            Console.WriteLine(Calculator.AreEqualTyped(1, 2));
            Console.WriteLine(Calculator.AreEqualObject("A", "A"));
            Console.WriteLine(Calculator.AreEqualObject("A", "B"));
            Console.WriteLine(Calculator.AreEqualObject("A",10)); // This is not type safe, and will always return with a false. This shouldn't be allowed in the first place.

            // Now using generics methods
            Console.WriteLine("Using Generics Method:");
            Console.WriteLine(Calculator.AreEqualUsingGenerics<String>("AA","AA"));
            Console.WriteLine(Calculator.AreEqualUsingGenerics<int>(2, 2));


            // Now using generic class

            Console.WriteLine("Using Generics Class:");
            GenericClassExample<int> genExI = new GenericClassExample<int>();
            Console.WriteLine(genExI.AreTheseEqual(10, 10));

            GenericClassExample<string> genExS = new GenericClassExample<string>();
            Console.WriteLine(genExS.AreTheseEqual("AA","AA"));
            
        }
    }

    public class Calculator
    {
        ///This method is tied to the int data types. And re-usability decreses if we want to achieve the same function with other datatypes. 
        ///Tightly coupled to the data type.
        ///
        public static bool AreEqualTyped(int val1, int val2) 
        {
            return val1 == val2;
        }

        /// <summary>
        /// This method is not strongly typed, as it used object type. Object type is directly or indirectly inherited by all the types available.
        /// The major problem with this implementation, is it goes through boxing, which is memory inefficient.
        /// Another major problem with this implementation is, it is not type safe and we could use this function to compare different data types which will always return with a false.
        /// </summary>
        /// <param name="val1">First value passed for comparision</param>
        /// <param name="val2">Second value passed for comparision</param>
        /// <returns>Boolean value</returns>
        public static bool AreEqualObject(object val1, object val2)
        {
            return val2 == val1;
        }

        /// <summary>
        ///  Example of using a generic method. This will make function we are trying to achieve type safe. 
        ///  There is no hard coded logic behind which type will this function operate on. No Boxing or unboxing happens in this situation.
        ///  Following function is type independent.
        /// </summary>
        /// <returns>Boolean value stating weather the passed values are equal or not.</returns>
        public static bool AreEqualUsingGenerics<T>(T val1, T val2)
        {   
            //return val1 == val2; // We cant use == to compare value if its generic. We have to use .Equals

            return val1.Equals(val2);
        }
    }

    /// <summary>
    /// This is an example of a generic class.
    /// This essentially means that all the methods an properties within the class are loosely coupled with the type of choice.
    /// This way, we need to specify the type during the object creation. Check in the main for this file for more details on newing up a generic object.
    /// </summary>
    public class GenericClassExample<T>
    {
        public bool AreTheseEqual(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
