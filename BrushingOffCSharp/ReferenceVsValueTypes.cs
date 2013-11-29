using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushingOffCSharp
{
    
    // Here we are going to see the differences between reference types (e.g. classes) and value types ( e.g. structs)
    // Struct cannot have argument less constructors.
    // Struct cannot have destructors.
    // Struct are value types.
    // When a copy of struct is made, new copy gets created and modifications on one does not affect values contained in by the other struct. e.g. int i,j; i = j;
    // A class or struct cannot inherit from another struct.
    // A Struct can inherit interface.
    //It is not possible to inherit a sealed class

    public struct EmployeeStruct //A Struct which looks exactly similar to any other classes. The only difference is the key word "Struct"
    {
        private int _id;

        public int Id // Only used when accessing the properties outside the class.
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;

        public string Name // Only used when accessing the property outside the class.
        {
            get { return _name; }
            set { _name = value; }
        }
        
        public EmployeeStruct(int i, string n) // Constructor with arguments. Struct cannot have argument less constructor.
        {
            this._id = i;
            this._name = n;
        }

        // Struct cannot have destructors.
        //~EmployeeStruct()
        //{ }

        //public EmployeeStruct() // Struct cannot have explicit argument less constructor.
        //{
        //    this._id = 2;
        //    this._name = "Silwal";
        //}

        public void PrintDetails()
        {
            Console.WriteLine("Id is {0} and Name is {1}", Id, Name);
        }

    }

    
    
    // A struct cannot inherit another struct. As struct are sealed type.
    //public struct DerivedStruct : EmployeeStruct 
    //{ }


    // A class cannot inherit from another struct. As struct are sealed type.
    // Error message looks like : cannot derive from sealed type.
    //public class DerivedFromStruct : EmployeeStruct
    //{ }



    // Structs and classes can inherit a interface.
    interface IImplementedInStruct
    {
        void print();
    }

    // A struct implementing an interface
    public struct ImplementsAnInterface : IImplementedInStruct
    {

        public void print()
        {
            Console.WriteLine("This Struct implements an Interface");
        }
    }


    //It is not possible to inherit a sealed class
    public sealed class ThisIsSealedClass
    {
        public void PrintMethod()
        {
            Console.WriteLine ("This is inside a sealed class");
        }
    }

    //Cannot Derive from Sealed Type
    //public class TryingToInheritASealedClass : ThisIsSealedClass
    //{
        
    //}

    
    class ReferenceVsValueTypes
    {
        public static void mainForReferenceAndValue()
        {
            EmployeeStruct e1 = new EmployeeStruct(1,"Binayak"); // Traditional way to instantiate a struct.
            e1.PrintDetails();

            EmployeeStruct e2 = new EmployeeStruct(); // Second lenghty way to instantiate a struct with some values.
            e2.Id = 2;
            e2.Name = "Silwal";
            e2.PrintDetails();

            // Following is known as object initializer syntax. 
            // Here we are directly assiging values to the public properties which used getters and setters.
            EmployeeStruct e3 = new EmployeeStruct {
                                    Id = 3,
                                    Name = "Karishma"
                                };
            e3.PrintDetails();


            //Lets check the scope of the struct
            //if (e3.Id == 3)
            //{
            //    EmployeeStruct e4 = e3;
            //}

            // Here e4 is not accessible as it is out of scope.
            //e4.PrintDetails();


            //Lets check the copying bit. If you copy structs the values remain independent and changing one doesn't change another.
            EmployeeStruct e5 = e3;
            e5.Id = 7;
            e5.Name = "Seven";
            Console.WriteLine("We created a new instance of Struct e5 = e3, following are the details of e3:");
            e3.PrintDetails();
            Console.WriteLine("Then we assigned new value to e5.Id = 7 and e5.Name = \"Seven\"");
            Console.WriteLine("Details of e5");
            e5.PrintDetails();

            //If you copy classes both are pointing to same Heap Memory object and changing one changes another, as only once change is occuring.
            Console.WriteLine("Where as if its a class:");
            EmployeeClass ec1 = new EmployeeClass(10, "Ten");
            Console.WriteLine("The details of original instance of employee class ec1 are ID: {0} and Name: {1}", ec1.Id, ec1.Name);
            EmployeeClass ec2 = ec1;
            Console.WriteLine("Now we performed copy operation: EmployeeClass ec2 = ec1");
            Console.WriteLine("The details of copy instance of employee class ec2 are ID: {0} and Name: {1}", ec2.Id, ec2.Name);
            ec2.Id = 11;
            Console.WriteLine("Now we performed ec2.Id = 11");
            Console.WriteLine("The details of original instance of employee class ec1 are ID: {0} and Name: {1}", ec1.Id, ec1.Name);
            Console.WriteLine("The details of copy instance of employee class ec2 are ID: {0} and Name: {1}", ec2.Id, ec2.Name);

            // Above demostrates difference between class types (reference types) and the struct types (value types)



            //Lest see how a struct can implement an Interface
            ImplementsAnInterface iStruct = new ImplementsAnInterface();
            iStruct.print();
        }

    }


    public class EmployeeClass //A class which looks exactly similar to the struct above.
    {
        private int _id;

        public int Id // Only used when accessing the properties outside the class.
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public EmployeeClass(int i, string n)
        {
            this._id = i;
            this._name = n;
        }

        ~EmployeeClass() // Destructors
        { }

        public void PrintDetails()
        {
            Console.WriteLine("Id is {0} and Name is {1}", Id, Name);
        }

    }
    
}
