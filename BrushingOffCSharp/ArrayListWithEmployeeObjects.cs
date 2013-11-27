using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushingOffCSharp
{
    
    class ArrayListWithEmployeeObjects
    {

        ArrayList alEmployee = new ArrayList();

        public void KickOff()
        {
            AddValueToTheArrayList();
            alEmployee.Reverse();
            //Following sorting is not allowed if custom objects are in the array list. The compiler wouldnt know how to compare this. 
            //For this, as suggested in the exception, we need to implement IComparable interface, then define sort criteria.
            //As a solution we implement IComparable to the Employee Class and implement methods, as in contract with the Interface.
            //alEmployee.Sort();  // This assuming is before implementing IComparable.
            alEmployee.Sort(); //This assuming is after implementing IComparable.
            // above sort method internally follows bubble sort algorithm.
            PrintMyArrayList();

        }

        public void AddValueToTheArrayList()
        {
            alEmployee.Add(new Employees(1, "Binayak"));
            alEmployee.Add(new Employees(5, "Silwal"));
            alEmployee.Add(new Employees(2,"Adam"));
            alEmployee.Add(new Employees(7,"Sira"));
        }

        public void PrintMyArrayList()
        {
            
            //foreach is only available for collection types.
            //foreach is internally using GetEnumerator() method present in the IEnumerable interface. 
            //The return type of GetEnumerator() is IEnumerator. 
            // IEnumerator interface implements three methods in it which are:
            //bool MoveNext() - This moves to the next object in the collection.
            // Object Current() - This points to the current object in the collection. This is object type, so needs casting when using with custom objects.
            // void Reset() - This resets the collection.

            foreach (Employees e in alEmployee)
            {
                Console.WriteLine(e.ID +" " + e.Name);
            }

            //Here I am trying to implement GetEnumerator() method present in IEnumerable to do exactly what foreach does for us.
            IEnumerator en = alEmployee.GetEnumerator();
            Console.WriteLine();
            Console.WriteLine("*************** PRINTING USING GetEnumerator() **********************");
            while (en.MoveNext())
            {
                Employees em = (Employees)en.Current;
                Console.WriteLine(em.ID + " " + em.Name);
            }
        }
    }

}
