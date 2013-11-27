using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushingOffCSharp
{
    class HashTables
    {
        //HashTables are not part of Collections.Generic. Hence we need to add namespace: System.Collections.


        //hashtable creation:

        public Hashtable myHash = new Hashtable();

        //Basic set of operation being done in the hash table in this class.
        public void SetMyHashTable()
        {
            GetMyHashTable();
            DoesMyHashTableContainsAKey("104");
            DoesMyHashTableContainsAKey("101");
            RemoveMyHashKey("102");
            GetTheValueOfIndexer("100");
            GetTheValueOfIndexer("abc");
            PrintMyHashTable();
            AddingKeysAndValuesToArrayLists();
            CountMyHashTable();
            IterateThroughTheHashTableUsingDictionaryEntry();
            ClearMyHashTable();
            
        }

        public void ClearMyHashTable ()
        {
            myHash.Clear();
            Console.WriteLine("Result after clearing my Hash Table: ");
            PrintMyHashTable();
        }

        public void IterateThroughTheHashTableUsingDictionaryEntry()
        {
            foreach (DictionaryEntry de in myHash)
            {
                
                //This is unboxing. We are taking objects from the hashtable and converting them in to appropriate data type.
                string key = de.Key.ToString();
                string value = de.Value.ToString();

                Console.WriteLine("DictionaryEntry Usage " + key + " " + value);
            }
        }
        public void CountMyHashTable()
        {
            int count = myHash.Count;
            Console.WriteLine("the result received after counting the hashtable is: {0}", count + 1);
        }


        //Add test data in the hash table
        public Hashtable GetMyHashTable()
        {
            
            //This is known as boxing. Here we are adding values as objects even though they are string type. Unboxing is done when we cast objects to their types. 
            myHash.Add("100", "binayak");
            myHash.Add("101", "Karishma");
            myHash.Add("102", "zulie");
            myHash.Add("103", "Cat");
            myHash.Add("222", "666");
            myHash.Add("abc", "123");
            
   
            return myHash;
        }

        //Just to print the has table.
        public void PrintMyHashTable()
        {
            foreach (string ID in myHash.Keys)
            {
                Console.Write(ID);
                Console.WriteLine(" " + myHash[ID]);
            }
        }

        
        //To get the value of indexer based of the passed param.
        public void GetTheValueOfIndexer(string p)
        {
            string value = (string)myHash[p];
            Console.WriteLine("The Value corresponding to the Indexer {0} is {1}", p, value);
        }

        //Checking if the hashtable contains passed key or not.
        public void DoesMyHashTableContainsAKey(string key)
        {
            if (myHash.ContainsKey(key)) //Checking if my hash table contains a key.
            {
                Console.Write("Key is: " + key + " and associated value is: ");
                Console.WriteLine(myHash[key]);
            }
            else
                Console.WriteLine("No Key " + key + " Found");
        }

        //Just to remove passed key from the hash table.
        public void RemoveMyHashKey(string key) //Removing my hash key
        {
            if (myHash.ContainsKey(key)) //Checking if my hash table contains a key.
            {
                Console.Write("Key is: " + key + " and associated value is: ");
                Console.WriteLine(myHash[key]);
                Console.WriteLine("Removeing the Key:" + key);
                myHash.Remove(key); // Removing specific key from my hash table.
  
            }
            else
                Console.WriteLine("No Key " + key + " Found");
        }


        //Adding keys and values to separate array lists.
        public void AddingKeysAndValuesToArrayLists()
        {
            ArrayList keyStore = new ArrayList(myHash.Keys); // A keyStore ArrayList to store all the keys in the hashtable.
            ArrayList valStore = new ArrayList(myHash.Values); // A keystore ArrayList to store all the values in the hashtable.

            foreach (string key in keyStore)
                Console.WriteLine(key);
                
            foreach (string val in valStore)
                Console.WriteLine(val);

            keyStore.AddRange(valStore); // adding range to the arraylist
            Console.WriteLine("Arraylist after adding range of val array list to the key array list: ");

            foreach (string key in keyStore)
                Console.WriteLine(key);
            

            
        }
    }

}
