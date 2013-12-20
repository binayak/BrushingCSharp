namespace BrushingOffCSharp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The KMP algorithm.
    /// this helps to search for a string within another string.
    /// e.g. Computer has put in it.
    /// </summary>
    public class KmpAlgorithm
    {
        /// <summary>
        /// The main for KMP.
        /// </summary>
        public static void MainForKMP()
        {
            NormalSearch("Computer","put");
        }

        /// <summary>
        /// The normal search.
        /// </summary>
        /// <param name="big">
        /// The big.
        /// </param>
        /// <param name="small">
        /// The small.
        /// </param>
        public static void NormalSearch(string big, string small)
        {
            char[] b = big.ToCharArray();
            char[] s = small.ToCharArray();

            Console.WriteLine(big.Contains(small));
            Console.WriteLine(big.IndexOf(small));
        }
    }

    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    /// <summary>
    /// The string searcher.
    /// This class implements Knuth Morris Prat Algorithm to search a string.
    /// To DO implement pseudo code from Wiki.
    /// </summary>
    public class StringSearcher
    {
        /// <summary>
        /// The s.
        /// the text to be searched
        /// </summary>
        private char[] s;

        /// <summary>
        /// The w.
        /// the word sought
        /// </summary>
        private char[] w;

        /// <summary>
        /// The index.
        /// </summary>
        private int index;

        

    }
}
