// --------------------------------------------------------------------------------------------------------------------
// <copyright file="JaggedArray.cs" company="home">
//   This is Jagged Array.
// </copyright>
// <summary>
//   Defines the JaggedArray type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BrushingOffCSharp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The jagged array.
    /// </summary>
    public class JaggedArray
    {
        /// <summary>
        /// The main for jagged array.
        /// </summary>
        public static void MainForJaggedArray()
        {
            string[][] jaggedArray = new string[3][];

            jaggedArray[0] = new string[1];
            jaggedArray[1] = new string[2];
            jaggedArray[2] = new string[3];

            jaggedArray[0][0] = "First Jagged Array has only one array with one element";
            
            jaggedArray[1][0] = "Second Jagged Array has 1 array with two elements, this is first";
            jaggedArray[1][1] = "Second Jagged Array has 1 array with two elements, this is second";

            jaggedArray[2][0] = "Third Jagged Array has 1 array with three elements, this is first";
            jaggedArray[2][1] = "Third Jagged Array has 1 array with three elements, this is second";
            jaggedArray[2][2] = "Third Jagged Array has 1 array with three elements, this is third";

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                string[] innerArray = jaggedArray[i];

                for (int j = 0; j < innerArray.Length; j++)
                {
                    Console.WriteLine(innerArray[j]);
                }

            }


        }
    }
}
