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
            for (int i = 0; i < valCount; i++)
            {
                myList.Add(i + 1);
            }

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            Console.WriteLine("The Size of your List is: " + myList.Count);
        }

        
    }
}
