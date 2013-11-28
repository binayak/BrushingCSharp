using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushingOffCSharp
{
    // A Delegate is type safe function pointer.
    // What do you mean by type safe? Types should match in delegates. If types do not match, it will throw error.
    // Delegates help in reusability of classes. Decouple the actual logic from framework classes.
    // If we have to pass a function a as a parameter then we should think of delegate.
    
    
    //This is delegate definition. 
    //Syntax is:
    // delegate return_type delegate_type_name(Parameters);
    delegate void Del (String s);
    //This is a delegate with a return type.
    delegate string Gate (string n);
    //This is a delegate with out parameter in it.
    delegate void delOut (out string s);

    class DelegatesProgram 
    {
        static void PrintIt(String p)
        {
            
            Console.WriteLine(p);
        }

        public void WriteMyName(String n)
        {
            Console.WriteLine(n);
        }

        public void WriteMyNumber(String num)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(num);
            foreach (int b in asciiBytes)
            {
                Console.WriteLine(b);
            }
        }

        public string ReturnMyName(String name)
        {
            name = "This is returning passed argument : "+name;
            return name;
        }

        public void ReturnMyLastName(out String lName)
        {
            lName = "Silwal is my last name";
            
        }

        public void AccessIt ()
        {
            //This is delegate instantiation.
            //Syntax:
            // delegate_type_name delegate_obj_name = method_name;

            Del d = PrintIt;

            //This is delegate invocation
            //syntax:
            //delegate_obj_name(arguments);
            d("Can you believe that delegate is printing this ? ");

            //This is classical way of invocating delegates.
            //Syntax:
            //delegate_type_name delegate_obj_name = new delegate_type_name(method_name);
            Del dd = new Del(PrintIt);

            //This is delegate invocation.
            dd("this is being printed by second delegate");


            //This is anonymous method definition using delegates
            //Syntax:
            // delegate_type_name delegate_obj_name = delegate(parameters) {implementation;};
            Del ff = delegate (string f)
            {
                Console.WriteLine (f);
            };
            
            //This is anonymous method invocation.
            ff("This is printed using anonymous method");


            //This is delegate Muticasting, where one delegate_obj will have many methods in it.
            //Syntax:
            //delegate_obj_name += method_name
            //All methods added to the "invocation list" should have same signature.
            //All methods in the invocation list will be invoked in the order they were added in.
            Del multi = WriteMyName;
            multi += WriteMyNumber;
            multi("Apple");

            //This is how you remove method from the invocation list.
            multi -= WriteMyName;
            Console.WriteLine("After removing method form the invocation list");
            multi("Binayak");


            //Lets see an example of delegate referencing a method with a return type.
            String returnedVal;
            Gate g = ReturnMyName;
            returnedVal = g("Binayak");
            Console.WriteLine(returnedVal);

            //This example is for a delegate with Out parameter. 
            //Delegate definition, calling method, and method called should all have out parameters in it.
            String s;
            delOut o = ReturnMyLastName;
            o(out s); // Even if the method called "ReturnMyLastName" returns void, the value of "s" is set in the method, and we can print it.
            Console.WriteLine(s);        
        }


    }

    //Lets see how we can take advantage of delegates to separate implemetation of data storage from implementation of data processing.
    //This can be achieved by passing delegates as method parameters. This is very important and useful concept of delegates.
    delegate void personPro (string s);
    class PersonDB // Assuming this class as data storage class.
    {
        ArrayList personNames = new ArrayList(5);
        public PersonDB()// Constructor to populate the ArrayList.
        {
            personNames.Add("Binayak");
            personNames.Add("Karishma");
            personNames.Add("Prateva");
            personNames.Add("Akangchya");
            personNames.Add("Anamika");
        }

        public void IteratePersonNames(personPro p) //Function which takes delegate object as parameter. Delegates can be passed as method parameters.
        {
            foreach (string name in personNames) p(name); // Iterate through the ArrayList and for each entry in the collection as argument, invoke PrintPersonName method referenced by the delegate object.
        }

    }

    class ProcessPerson
    {
        public void mainForThis()
        {
            PersonDB person = new PersonDB();// creating new object of the calls PersonDB.
            person.IteratePersonNames(PrintPersonName); // Calling the funtion, and passing method name so that method excepting argument can refer the method using the delegate object.
        }

        public void PrintPersonName(string s)
        {
            Console.WriteLine(s);

        }
    }
}
