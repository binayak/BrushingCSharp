using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushingOffCSharp
{
    class Lists
    {
        //Arrays does not dynamically resize. A list does
        // This type is ideal for linear collectins not accessed by keys.
        // List is a generic (constructed) type.
        // List can also hold objects and reference types.


        List<int> myList = new List<int>();

        public void AddToMyListThenPrint(int valCount)
        {
            for (int i = 0; i < valCount; i++) //using for loop to add data into list
            {
                myList.Add(i + 1); // Adding values into the list.
            }

            //for (int i = 0; i < myList.Count; i++)
            foreach(int num in myList) //using foreach loop to access data in the list
            {
                Console.WriteLine(myList[num-1]);
            }

            Console.WriteLine("The Size of your List is: " + myList.Count); // using count to return size of the list.

            //clearMyList(myList);
            nullMyList(myList);

        }

        public void clearMyList(List<int> myList)// using clear to empty the list.
        {
            myList.Clear(); 
            Console.WriteLine("The Size of your List after clearing is: " + myList.Count);
        }

        public void nullMyList(List<int> myList) // NULL assignment, it will create an exception if you count.
        {
            myList = null;
            Console.WriteLine("The Size of your List after assing NULL is: " + myList);
        }

        public void CopyArrayInToAList(int[] myArr) //Copying array into a List
        {
            List<int> myList = new List<int>(myArr);
            foreach(int indx in myList)
            {
                Console.WriteLine(myList[indx-1]); //This throws exception for the data value -1
            }

            if (myList.Contains(5)) // Checking if the list contains data 5 or not.
                Console.WriteLine("You list contains 5");

            if (myList.Exists(element => element == 5)) //Using Lambda expression on Exists. input => expression.
                Console.WriteLine("5 Exists in your list");

            int FindIndex = myList.IndexOf(-1); //Finding the index value of a data in the list.
            Console.WriteLine("The index of -1 is: " + FindIndex);

            //Other IndexOf Overloads:
            //String.IndexOf
            //String.LastIndexOf
            //Array.IndexOf
            //Array.LastIndexOf
        }

        public void CollectionCapacity()
        {
            //The capacity of a Dictionary(TKey, TValue) is the number of elements that can be added to the Dictionary(TKey, TValue) before resizing is necessary.
            
            //Why to Set Capacity?
            //If the size of the collection can be estimated, specifying initial capacity eliminates the need to perform number of resizing operations 
            //while adding elements to the collection.

            List<int> myList = new List<int>(100); //Here hte capacity of the list is estimated and set to 100.

            //The memory model of .NET programs is complex. It is efficient and takes care of most of the hard stuff. 
            //But giving it hints about the sizes of the collections is a substantial optimization.

            //Use TrimAccess method to remove all the unused but allocated capacity.
            //It reduces the memory used by lists with large capacities.

            myList.TrimExcess(); //Trimming access memory usage.
        }

        public void BinarySearchInList()
        {
            //Binary search has O(log n) complexity, making it more efficient than others.
            //Binary search is faster in Dictionary than in Lists.

            List<string> myList = new List<string>();

            myList.Add("Apple");
            myList.Add("Banana");
            myList.Add("Pineapple");
            myList.Add("Cucumber");
            myList.Add("Orange");
            myList.Add("Mangosteen");
            myList.Add("Guava");

            for (int i = 0; i < myList.Count; i++ )
            {
                Console.Write(i);
                Console.WriteLine(": "+myList[i]);

                Console.WriteLine(myList[i]+" is found by performing binary search at the index of: " + myList.BinarySearch(myList[i]));
                //BinarySearch is behaving differently here, it couldnt find some of the items and is returning negative numbers.specially for 2,4,&6.
            }                       
        }

        public void JoinStringList()
        {
             //This is helpful when you need to turn several strings into one comma-delimited string. 
             //It requires the ToArray instance method on List. This ToArray is not an extension method.

            List<string> myList = new List<string>();

            myList.Add("England");
            myList.Add("Scotland");
            myList.Add("France");
            myList.Add("India");
            myList.Add("Tibet");
            myList.Add("Italy");

            string travelled = string.Join(",",myList.ToArray());
            Console.WriteLine(travelled);
        }

        public void KeysInDictionary()
        {
            //We use the List constructor to get a List of keys or values from a Dictionary. 
            //This is a simple way to iterate over Dictionary keys or store them elsewhere. 
            //The Keys property returns an enumerable collection of keys.

            Dictionary<int, string> myDict = new Dictionary<int, string>();

            myDict.Add(1,"Binayak");
            myDict.Add(2,"Karishma");
            myDict.Add(3, "Aryan");

            List<int> dictKeys = new List<int>(myDict.Keys); //Assiging dictionary keys to the list.
            List<string> dictVals = new List<string>(myDict.Values); //Assiging dictionary values to the list.

            foreach (int i in dictKeys)
            Console.WriteLine(i +":"+ dictVals[i-1]);
        }

        public void UsingInserMethodInAList()
        {
            //You can insert an element into a List at any position. The string here is inserted into index 1. 
            //This makes it the second element. 
            //If you have to Insert often, please consider Queue and LinkedList.

            List<string> dogs = new List<string>();

            dogs.Add("Doberman");
            dogs.Add("Bulldog");
            dogs.Add("German Shepard");
            dogs.Add("Great Dane");

            Console.WriteLine("This is before the insert!");
            foreach (string i in dogs)
                Console.WriteLine(i + "->has the index:" + dogs.IndexOf(i));

            dogs.Insert(2,"PitBull");
            Console.WriteLine();
            Console.WriteLine("This is after the insert!");
            foreach (string i in dogs)
                Console.WriteLine(i + "->has the index:"+dogs.IndexOf(i));

            //There is another method called InsertRange which can insert an array into specified location in the list.

            //Similar to Insert there are remove methods as well.
            //Remove
            //RemoveAt
            //RemoveRange  
            //RemoveAll
        }

        public void SoringList()
        {
            List<string> names = new List<string>();
            names.Add("Mno");
            names.Add("Def");
            names.Add("Ghi");
            names.Add("Jkl");
            names.Add("Abc");

            List<int> numbers = new List<int>();
            numbers.Add(9);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

            names.Sort();
            numbers.Sort();

            foreach (string i in names)
                Console.WriteLine(i);

            foreach (int j in numbers)
                Console.WriteLine(j);

            Console.WriteLine();
            Console.WriteLine("*****Reversing the List******");
            names.Reverse();
            numbers.Reverse();

            foreach (string i in names)
                Console.WriteLine(i);

            foreach (int j in numbers)
                Console.WriteLine(j);



        }
        
    }
}
