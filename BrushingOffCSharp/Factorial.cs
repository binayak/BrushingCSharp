// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Factorial.cs" company="">
//   
// </copyright>
// <summary>
//   The factorial.
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
    /// The factorial.
    /// </summary>
    public class Factorial
    {
        /// <summary>
        /// The main for factorial.
        /// </summary>
        public static void MainForFactorial()
        {
            Console.WriteLine("Please enter a number to calcuclate Factorial with out using Recursion:");
            double number = Convert.ToInt32(Console.ReadLine());
            double factorialResult = CalcFactorialWithoutRecursion(number);
            Console.WriteLine("The factorial of the number {0} is {1}",number.ToString(),factorialResult.ToString());


            Console.WriteLine("calcuclating Factorial with using Recursion:");
            double factorialResult1 = CalcFactorialWithRecursion(number);
            Console.WriteLine("The factorial of the number {0} is {1}", number.ToString(), factorialResult1.ToString());
        }

        /// <summary>
        /// The calculate factorial without recursion.
        /// </summary>
        /// <param name="n">
        /// The n.
        /// </param>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        public static double CalcFactorialWithoutRecursion(double n)
        {
            if (n == 0)
            {
                return 1;
            }

            double result = 1;

            for (double i = n; i >= 1; i--)
            {
                result = result * i;
            }
            return result;
        }

        /// <summary>
        /// The calculate factorial with recursion.
        /// </summary>
        /// <param name="n">
        /// The n.
        /// </param>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        public static double CalcFactorialWithRecursion(double n)
        {
            double result = 1;

            if (n == 0)
            {
                return 1;
            }
            else
            {
                result = n * CalcFactorialWithRecursion(n - 1);
                return result;
            }
        }
    }
}
