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
            //obj.ArrayReverseWithAForLoop();
            


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
            //ListObj.PrintFamily(myAncestor);
            

            ArrayListWithEmployeeObjects arObj = new ArrayListWithEmployeeObjects();
            //arObj.KickOff();
           
            Lists myList = new Lists();
            //myList.AddToMyListThenPrint(25);
            //myList.CopyArrayInToAList(new int[] { 1, 2, 3, 4, 5, -1});
            //myList.BinarySearchInList();
            //myList.JoinStringList();
            //myList.KeysInDictionary();
            //myList.UsingInserMethodInAList();
            //myList.SoringList();


            HashTables hash = new HashTables();
            //hash.SetMyHashTable();

            Dictionary dict = new Dictionary();
            //dict.DictionaryParentFunction();

            DelegatesProgram delObj = new DelegatesProgram();
            //delObj.AccessIt();

            ProcessPerson person = new ProcessPerson();
            //person.mainForThis();

            Lambda lamb = new Lambda();
            //lamb.mainFunctionForLambdaClass();


            //InterfacesProgram.mainForInterface();


            //ReferenceVsValueTypes.mainForReferenceAndValue();

            StackOperations.mainForStack();

            //BoxingAndUnboxing.mainForBoxUnbox();
            

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Press enter to exit!!");
            //Console.ReadLine();
        }
    }
}
