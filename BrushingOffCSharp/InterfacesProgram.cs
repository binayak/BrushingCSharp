using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushingOffCSharp
{

    interface IEmployees
    {
        void printEmployees();
    }

    interface IEmployer
    {
        void printEmployer();
    }

    interface IContractor : IEmployees // Interface inheriting another interface. This way the class inheriting interface IContractor needs to implement all the methods in the chain.
    {
        void printContract();
    }

    class Employee : IEmployer, IContractor // Multiple Interface Inheritance
    {
     

        public void printEmployer()
        {
            Console.WriteLine("This is Employer");
        }

        public void printContract()
        {
            Console.WriteLine("This is Contractor");
        }

        public void printEmployees()
        {
            Console.WriteLine("This is Employee");
        }

        public void printMyName()
        {
            Console.WriteLine("My Name is Binayak");
        }
    }

    class InterfacesProgram
    {
        // Interfaces are similar to classes, but contains only declarations, no implementations. 
        // Interface members are public by default. We cannot have explicit excess modifiers.
        // Interface cannot contain fields. e.g: int i
        // A class can inherit an interface.
        // When a class inherits an interface, it must provide implementation for the methods declared in the interface.
        // Classes allow multiple interface inheritance
        // It is not possible to new-up an interface instance.
        // But we can create an interface type object and assign it to new derived class.
        // A Parent Class reference variable can point to child class object.

        public static void mainForInterface()
        {
            Employee e1 = new Employee();
            e1.printEmployees();
            e1.printEmployer();
            e1.printContract();

            IEmployer emp1 = new Employee(); //  Assigning an interface type object to new derived class type. A parent class reference variable can point to child class object.
            emp1.printEmployer(); // Then we can use the interface type object to invoke its own method implemented in the derived class.
            

            //Following explicit examples:
            PrintingNames pn = new PrintingNames();
            pn.mainForPrintingNames();


            // Following default interface implementation.
            // A combination of both normal and explicit interface method implementation in the derived class.
            ExampleOfDefaultImplementation exDef = new ExampleOfDefaultImplementation();
            exDef.mainForDefault();
            
        }
    }


    // Questions: What happens if a class implements two interfaces and both of them has exactly same method with same signature, and class has implemented one method to cater both scenarios? 
    // .NET thinks that the rules around interface are obeyed.And doesn't throw any compile time error. But this does create ambiguity, and may result with logical error.
    // There is a way to type cast the method and call the method, but since implementation is same, ambiguity still exists.
    // In this case we need to do explicit interface implementation.
    // Derived class object reference variable cannot direclty call explicitly implemented method.
    
    // Default implementation: If we have above "Question" case then we could implement on method the normal way and another Explicitly, this way the one implemented normally will become 
    //default implementation.

    //Rules for explicit interface implementation:
    // 1. You are not allowed to use access modifiers.
    // 2. You have to add interface name in the syntax. E.g: return_type IInterfaceName.MethodName(){}
    // 3.1 You invoke methods by type casting derived class object to the interface of choice.
    // 3.2 Option to the type casting is to create Interface Reference variable, assign it to new Derived class object and calling method using interface reference variable.



    interface IOne
    {
        void PrintYourName();
    }

    interface ITwo
    {
        void PrintYourName();
    }

    class PrintingNames : IOne, ITwo
    {

        void IOne.PrintYourName() // Explicit interface method implementation
        {
            Console.WriteLine("Your Name is Karishma");
        }

        void ITwo.PrintYourName() // Explicit interface method implementation
        {
            Console.WriteLine("Your Name is Tripathy");
        }
        
        public void mainForPrintingNames()
        {
            PrintingNames pn = new PrintingNames();
            ((IOne)pn).PrintYourName(); //Type casting the derived class object to desired interface, hence ambiguity reduction.
            ((ITwo)pn).PrintYourName();

            //Option to Type cast is:
            IOne i1 = new PrintingNames(); // Interface instance reference variable pointing to new derived class object. Concept of inheritence.
            ITwo i2 = new PrintingNames();

            i1.PrintYourName(); 
            i2.PrintYourName();
        }
    }




    /// For the concept of default implementation
    /// 

    interface IA1
    {
        void PrintAddress();
    }

    interface IA2
    {
        void PrintAddress();
    }

    public class ExampleOfDefaultImplementation: IA1,IA2
    {

        public void PrintAddress() // Here we are making method derived from IA1 interface as default implementation.
        {
            Console.WriteLine("Her Address is Ilford - Using Default Implementation");
        }

        void IA2.PrintAddress() // Explicit implementation
        {
            Console.WriteLine("My Address is Charlton - Using Explicit Implementation");
        }


        public void mainForDefault()
        {
            ExampleOfDefaultImplementation def = new ExampleOfDefaultImplementation();
            def.PrintAddress(); // Invoking implemented method normal way. Which makes it default.

            IA2 sec = new ExampleOfDefaultImplementation();
            sec.PrintAddress(); // Invoking explicitly implemented method. This way ambiguity is removed.

            // Again you can also type cast and call the explicit implemented method.
            ((IA2)def).PrintAddress();

        }
    }

}
