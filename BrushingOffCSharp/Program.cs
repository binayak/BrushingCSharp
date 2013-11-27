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
            //obj.ArraySetSortSolutionOne();
            //obj.ArraySetSortSolutionTwo();
            //obj.ArraySumsUpToASpecificValue();
            //obj.ArrayChooseNumberToSumUp();
            //obj.ArrayReverseWithAForLoop();

            ArrayListWithEmployeeObjects arObj = new ArrayListWithEmployeeObjects();
            arObj.KickOff();

            
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



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press enter to exit!!");
            Console.ReadLine();
        }
    }
}
