using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushingOffCSharp
{
    class Employees : IComparable
    {
        public int ID;
        public string Name;

        public Employees(int i, string n)
        {
            ID = i;
            Name = n;
        }


        //This is the method Sort() will call internally, in order to compare two objects. 
        //Current object using Sort will call this method passing object to which comparison should be done as argument.
        //As we can tell, CompareTo method has integer as the return type. We have to return either 0, 1, or -1.
        // if comparision yields less than zero then current object precedes object in comparision.
        // if comparision yields zero then current object is in same position as object in comparision.
        //if comparision yields more than zero then current object follows object in comparision.
        public int CompareTo(object obj)
        {
            //The passed argument is of type object. Hence we need to perform type casting to Employee type.
            Employees comTo = (Employees)obj;

            if (this.ID > comTo.ID)
                return 1;
            else if (this.ID < comTo.ID)
                return -1;
            else 
                return 0;
        }
    }
}
