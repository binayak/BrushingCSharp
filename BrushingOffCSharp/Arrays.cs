using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushingOffCSharp
{
    class Arrays
    {
        

        //Questions: if you have array [1,2,3,4,0,0,-5,-4,3,-2,0,0,9]
        //without using any algorithms sort it by types e.g.
        //    [-5,-2,-4,0,0,0,0,1,3,2,4,3,9]

        public void ArraySetSortSolutionOne()
        {
            int [] data = new int [13] {1,2,3,4,0,0,-5,-4,3,-2,0,0,9};
            int dataLength = data.Length;
            int tempIndex = 0;
            int [] tempArray = new int [dataLength];
            
            for (int i = 0; i < dataLength - 1; i++)
            {
                if (data[i] < 0)
                {
                    tempArray[tempIndex] = data[i];
                    tempIndex++;
                }
            }

            for (int i = 0; i < dataLength - 1; i++)
            {
                if (data[i] == 0)
                {
                    tempArray[tempIndex] = data[i];
                    tempIndex++;
                }
                  
            }

            for (int i = 0; i < dataLength - 1; i++)
            {
                if (data[i] > 0)
                {
                    tempArray[tempIndex] = data[i];
                    tempIndex++;
                }
                  
            }

            Console.WriteLine("******************* Array Solution One **************************");
            Console.WriteLine();
            for (int i = 0; i < dataLength - 1; i++)
            {
                Console.Write(tempArray[i]);                
            }

                Console.ReadLine();
        }

        public void ArraySetSortSolutionTwo()
        {
            int[] data = new int[13] { 1, 2, 3, 4, 0, 0, -5, -4, 3, -2, 0, 0, 9 };
            int dataLength = data.Length;
            int tempIndexMin = 0;
            int tempIndexMax = dataLength -1;
            int[] tempArray = new int[dataLength];

            for (int i = 0; i < dataLength - 1; i++)
            {
                if (data[i] < 0)
                {
                    tempArray[tempIndexMin] = data[i];
                    tempIndexMin++;
                }

                else if (data[i] > 0)
                {
                    --tempIndexMax;
                    tempArray[tempIndexMax] = data[i];
                    
                }               
  

            }

            Console.WriteLine("******************* Array Solution Two **************************");
            Console.WriteLine();
            for (int i = 0; i < dataLength - 1; i++)
            {
                Console.Write(tempArray[i]);
            }

            Console.ReadLine();



        }


        
        //********************************************************************

        //Question: Given an integer array, output all pairs that sum up to a specific value k.

        public void ArraySumsUpToASpecificValue()
        {
            int K = 6;
            int[] TheArray = {1, 2, 3, 4, 5, 3 ,2 ,4 };

            int len = TheArray.Length;

            for (int i = 0; i < len - 1; i++)
            {
                for (int j = 0; j < len-1; j++ )
                {
                    if ((TheArray[i] + TheArray[j] == K)&&(i!=j))
                    {
                        Console.Write(TheArray[i]);
                        Console.WriteLine(TheArray[j]);
                    }
                }
                    
            }

            Console.ReadLine();
        }

        //********************************************************************


        //Questions: Assume we have three arrays of length N which contain arbitrary numbers of type long. Then we are given a number M (of the same type)
        //and our mission is to pick three numbers A, B and C one from each array so the sum A + B + C = M.        
        //Question: could we pick all three numbers and end up with time complexity of O(N2)?

        //1) 6 5 8 3 9 2
        //2) 1 9 0 4 6 4
        //3) 7 8 1 5 4 3
        //And M we've been given is 19. Then our choice would be 8 from first, 4 from second and 7 from third.

        public void ArrayChooseNumberToSumUp()
        {
            int[] First = {6,5,8,3,9,2};
            int[] Second = {1,9,0,4,6,4};
            int[] Third = {7,8,1,5,4,3};

            int SumRequired = 19;

            int FLen = First.Length;
            int SLen = Second.Length;
            int TLen = Third.Length;

            if (!(FLen == SLen) && !(SLen == TLen))
                Console.WriteLine("The given arrays are not same size!!");

            for (int i = 0; i < FLen - 1; i++)
            {
                for (int j = 0; j < FLen; j++)
                {
                    for (int k = 0; k < FLen; k++)
                    {
                        if (First[i] + Second[j] + Third[k] == SumRequired)
                            Console.WriteLine(First[i] + " " + Second[j] + " " + Third[k] + " sums up to give " + SumRequired);
                    }
                }
            }

            Console.ReadLine();

        }

        public void ArrayReverseWithAForLoop()
        {
            int[] First = { 6, 5, 8, 3, 9, 2 };

            for (int i = 0; i < First.Length; i++ )
                Console.WriteLine(First[i]);
            int[] temp = new int[6];
            int k = 0;
            int len = First.Length;
            for (int j = len-1; j >=0; j--)
            {

                temp[k] = First[j];
                k = k + 1;
            }

            Console.WriteLine("******* AFTER REVERSAL ******");

            for (int i = 0; i < First.Length; i++)
                Console.WriteLine(temp[i]);

        }


    }
}
