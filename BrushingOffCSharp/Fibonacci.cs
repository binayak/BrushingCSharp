namespace BrushingOffCSharp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The fibonacci.
    /// </summary>
    public class Fibonacci
    {
        /// <summary>
        /// The main for fibonacci.
        /// </summary>
        public static void MainForFibonacci()
        {

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(CalcFibo(i));
            }

            Console.WriteLine("The 5th element in Fibonacci contains: {0}", NthElement(5));

            Console.WriteLine("The 5th element in Fibonacci contains without using recursion: {0}", NthElementWithoutRecursion(5));
            

        }

        /// <summary>
        /// The calculate fibonacci.
        /// </summary>
        /// <param name="n">
        /// The n.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public static int CalcFibo(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        /// <summary>
        /// To find the nth element.
        /// </summary>
        /// <param name="n">This is the parameter</param>
        /// <returns>it returns value in nth element</returns>
        public static int NthElement(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                int ans1 = NthElement(n - 1);
                int ans2 = NthElement(n - 2);
                int ans = ans1 + ans2;
                return ans;
            }

        }

        /// <summary>
        /// The nth element without recursion.
        /// </summary>
        /// <param name="n">
        /// The n.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public static int NthElementWithoutRecursion(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                int a = 0;
                int b = 1;

                for (int i = 0; i < n; i++)
                {
                    int temp = a;
                    a = b;
                    b = b + temp;
                }
                return a;

            }

        }
    }
}
