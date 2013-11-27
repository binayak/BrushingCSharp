using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushingOffCSharp
{
    public class ListExamples
    {

        //Question:
        //abstract class Person 
        //{
        //    public string Name { get; set; }
        //}
        //class Child : Person { }
        //class Parent : Person 
        //{
        //    public List<Person> Children { get; set; }
        //}
        //class Ancestor : Parent { }
        //----------------------------------
        //Ancestor myAncestor = new Ancestor {    
        //    Name = "GrandDad",
        //    Children = new List<Person> { 
        //        new Child { Name = "Aunt" },
        //        new Child { Name = "Uncle" },
        //        new Parent {
        //            Name = "Dad", 
        //            Children = new List<Person> { 
        //                new Child { Name = "Me" }, 
        //                new Child { Name = "Sister" } 
        //            }
        //        }
        //    }
        //};
        //--------------------------------------
        //GrandDad  
        //-    Aunt  
        //-    Uncle  
        //-    *Dad  
        //         -Me  
        //         -Sister
        //-------------------------------------
        //All the processing needs to be done within a single method that accepts a single parameter of type Ancestor.

        public void PrintFamily(Ancestor a)
        {
            Action<Parent, int> printParent = null;
            printParent = (parent, level) =>
            {
                var indentation = new string(' ', level * 4);
                var indentationChildren = new string(' ', (level + 1) * 4);
                Console.WriteLine(indentation + parent.Name);
                foreach (var child in parent.Children)
                {
                    if (child is Child)
                        Console.WriteLine(indentationChildren + child.Name);
                    else if (child is Parent)
                    {
                        printParent((Parent)child, level + 1);
                    }
                }
            };

            printParent(a, 0);
            Console.WriteLine("Press any key to continue...");
            Console.Read();
        }

    }
}

public abstract class Person
{
    public string Name { get; set; }
}

public class Child : Person { }

public class Parent : Person
{
    public List<Person> Children { get; set; }
}

public class Ancestor : Parent { }
