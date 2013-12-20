// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Palindrome.cs" company="Home">
//   
// </copyright>
// <summary>
//   The palindrome.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BrushingOffCSharp
{
    using System;

    /// <summary>
    /// The palindrome.
    /// </summary>
    internal class Palindrome
    {
        /// <summary>
        /// The main for palindrome.
        /// </summary>
        public static void MainForPalindrome()
        {
            Console.WriteLine("Please enter a word to figure out if it is a palindrome or not:");
            string checkEntry = Console.ReadLine();
            Console.WriteLine("Checking using function using temp variable");
            IsPalindromeUsigTempVariable(checkEntry);
            Console.WriteLine("Checking using function using no temp variable");
            bool val = IsPalindrome(checkEntry);
            if (val == true)
            {
                Console.WriteLine(checkEntry + " is palindrome");
            }
            else
            {
                Console.WriteLine(checkEntry + " is not palindrome");
            }

        }

        /// <summary>
        /// The is palindrome.
        /// </summary>
        /// <param name="s">
        /// The s.
        /// </param>
        public static void IsPalindromeUsigTempVariable(string s)
        {
            int len = s.Length;
            string str = string.Empty;

            // we can get the Length of string by using Length Property
            for (int j = len - 1; j >= 0; j--)
            {
                str = str + s[j];
            }
            if (str == s)
            {
                Console.WriteLine(s + " is palindrome");
            }
            else
            {
                Console.WriteLine(s + " is not a palindeome");
            }
        }

        /// <summary>
        /// The is palindrome.
        /// </summary>
        /// <param name="s">
        /// The s.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public static bool IsPalindrome(string s)
        {
            int len = s.Length;

            for (int i = 0; i < len / 2; i++)
            {
                if (s[i] == s[len - 1 - i])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}

