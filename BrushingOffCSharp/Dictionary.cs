using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushingOffCSharp
{
    class Dictionary
    {
        public Dictionary<string, int> myDict = new Dictionary<string, int>();

        public Dictionary<string, int> SetKeyValuesToTheDictionary()
        {
            myDict.Add("Binayak", 30);
            myDict.Add("Karishma", 28);
            myDict.Add("Prativa", 22);
            myDict.Add("Somebody", -1);

            return myDict;
        }

        public void DictionaryParentFunction()
        {
            SetKeyValuesToTheDictionary();
            CheckIfGivenValueExistsInTheDictionary("Binayak");
            CheckIfGivenValueExistsInTheDictionary("Hello");
            DifferentWaysToLoopThroughTheDictionary();
            UsingKeysAndValuesPropertyToAddKeysAndValuesToDifferentLists();
            
        }

        

        public void UsingKeysAndValuesPropertyToAddKeysAndValuesToDifferentLists()
        {
            List<string> values = new List<string>(myDict.Keys);
            List<int> keys = new List<int>(myDict.Values);

            foreach (string val in values)
                Console.WriteLine("The keys are {0}", val);

            foreach (int val in keys)
                Console.WriteLine("The values are {0}", val);
        }

        public void CheckIfGivenValueExistsInTheDictionary(string q)
        {
            if (myDict.ContainsKey(q))
            {
                int val = myDict[q];
                Console.WriteLine(val);
            }
            else
                Console.WriteLine("The key for \"{0}\" does not exists in the dictionary", q);
        }

        public void DifferentWaysToLoopThroughTheDictionary()
        {
            Console.WriteLine("*** First Method using KeyValuePair<> keyword ***");
            foreach (KeyValuePair<string, int> pair in myDict)
                Console.WriteLine("The key is \"{0}\" and the value is \"{1}\"", pair.Key, pair.Value);

            Console.WriteLine("*** Second Method using var keyword ***");
            foreach (var pair in myDict)
                Console.WriteLine("The key is \"{0}\" and the value is \"{1}\"", pair.Key, pair.Value);

        }
    }
}
