using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace BrushingOffCSharp
{


    class Lambda
    {
        delegate double CalAreaPointer(int radius);
        //static CalAreaPointer ca = CalculateAreaCircle;

        public void mainFunctionForLambdaClass()
        {

            //double resultArea = ca(20);

            //CalAreaPointer cc = delegate(int r) // Example of Anonymous method. Using this we can get rid of the extra method that we created to calculate area of the circle "CalculateAreaCircle"
            //{
            //    return (3.14 * r * r);
            //};

            //double resultArea = cc(20);

            // Now replacing anonymous fuction with Lambda expression, we can create a shorter and sweeter code to compute radius of the circle.
            CalAreaPointer ap = r => 3.14 * r * r; // Lambda expression.
            double resultArea = ap(20);
            Console.WriteLine(resultArea);


            // Looking into usage of GenericDelegateFunc
            GenericDelegateFunc GDF = new GenericDelegateFunc();
            GDF.MainForGDF();

            ActionGenericDelegate act = new ActionGenericDelegate();
            act.mainForAction();

            PredicateGenericDelegate pred = new PredicateGenericDelegate();
            pred.mainForPredicate();

            ExpressionTreesUsingLambdas exp = new ExpressionTreesUsingLambdas();
            exp.mainForExpressionTrees();


        }

        //public static double CalculateAreaCircle(int r)
        //{
        //    return 3.14 * r * r;
        //}
    }

    class GenericDelegateFunc
    {
        public void MainForGDF()
        {
            // Using Lambda + Func
            // Func is generic / ready-made delegate.
            // You can define inputs and outputs of different types.
            
            Func<double, double> cpointer = r => 3.14 * r * r;
            double resultArea = cpointer(20);
            Console.WriteLine("Printing using Func<> readymade/generic delegate");
            Console.WriteLine(resultArea);
        }
    }

    class ActionGenericDelegate
    {
        // Using Lambda + Action
        // Action is generic/ready-made delegate
        // Action is used only with functions which have return type as void. Only perform an action, dont give me anytihng back.
        
        public void mainForAction()
        {
            Action<string> stringPrintAction = b => Console.WriteLine(b);
            Console.WriteLine("Printing using ACtion<> readymade/generic delegate");
            stringPrintAction("Binayak");
        }     
    }


    class PredicateGenericDelegate
    {
        // Using Predicate + Lambda
        // Predicate is another generic/ready-made delegate
        // Predicate can be considered as the extension to the Func.
        // As in Func it can have inputs and outputs.
        // Predecate is mainly for checking purpose.
        // Return type is always boolean.

        public void mainForPredicate()
        {
            Predicate<string> checkGreaterThanFive = len => len.Length > 5;
        
            Console.WriteLine("Printing results given by Predicate <>");

            if (checkGreaterThanFive("Bin"))
                Console.WriteLine("The string has more than 5 characters");
            else
                Console.WriteLine("The string has less than 5 characters");



            // Another usage example of predicate in a list.
            List<string> lString = new List<string>();
            lString.Add("Binayak");
            lString.Add("Binay");
            lString.Add("Binay1234");

            Console.WriteLine("Using custom Predicate in List.Find");
            Console.WriteLine(lString.Find(checkGreaterThanFive));
        }
    }


    class ExpressionTreesUsingLambdas
    {
        // Most important functionality of Expression Tree is to create end user languages.
        
        //Lets solve followig problem
        // (10+20)-(5+3)
        // This requires System.Linq.Expressions namespace to be imported.

        public void mainForExpressionTrees()
        {
            BinaryExpression b1  = Expression.MakeBinary(ExpressionType.Add, 
                                                         Expression.Constant(10),
                                                         Expression.Constant(20)
                                                             );
            BinaryExpression b2 = Expression.MakeBinary(ExpressionType.Add,
                                                        Expression.Constant(5),
                                                        Expression.Constant(3)
                                                        );

            BinaryExpression sub = Expression.MakeBinary(ExpressionType.Subtract,b1,b2);

            int i = Expression.Lambda<Func<int>>(sub).Compile()();
            
            Console.WriteLine(i); 




        }

         
    }
}
