using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushingOffCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrays obj = new Arrays();
            //Uncomment following to execute each example.
            //obj.ArraySetSortSolutionOne();
            //obj.ArraySetSortSolutionTwo();
            //obj.ArraySumsUpToASpecificValue();
            //obj.ArrayChooseNumberToSumUp();

            ListExamples ListObj = new ListExamples();
            Ancestor myAncestor = new Ancestor
            {
                Name = "GrandDad",
                Children = new List<Person> 
                { 
                    new Child { Name = "Aunt" },
                    new Child { Name = "Uncle" },
                    new Parent 
                    {
                        Name = "Dad", 
                        Children = new List<Person> 
                        { 
                            new Child { Name = "Me" }, 
                            new Child { Name = "Sister" } 
                        }
                    }
                }
            };
            
        ListObj.PrintFamily(myAncestor);

        }
    }
}
