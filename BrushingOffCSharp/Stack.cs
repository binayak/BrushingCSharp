using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushingOffCSharp
{
    public interface IStackMethods
    {
        void push(object o);
        object pop();
        bool IsEmpty();
        object peek();
        void display();
    }

    class StackOperations : IStackMethods
    {
        private int sizeOfTheStack;
        public object[] myStack;
        public int topOfTheStack;

        public int SizeOfTheStack
        {
            get { return sizeOfTheStack; }
            set { sizeOfTheStack = value; }
        }

        public StackOperations()
        {
            topOfTheStack = -1;
            SizeOfTheStack = 5;
            myStack = new object[SizeOfTheStack];
        }

        public StackOperations(int size)
        {
            topOfTheStack = -1;
            SizeOfTheStack = size;
            myStack = new object[SizeOfTheStack];
        }

        public static void mainForStack()
        {

            StackOperations aStack = new StackOperations();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nThis is stack operation! Please select an option:");
                Console.WriteLine("1. Check if Stack is empty.");
                Console.WriteLine("2. Push value into the stack.");
                Console.WriteLine("3. Pop value back from the stack.");
                Console.WriteLine("4. Peek the top most element of the stack.");
                Console.WriteLine("5. Display all values in the stack.");
                Console.WriteLine("6. Exit.");

                int optionIn = Convert.ToInt32(Console.ReadLine());

                switch (optionIn)
                {
                    case 1: aStack.IsEmpty();
                        break;
                    case 2:
                        Console.WriteLine("Please enter the value you wish to push into the stack:");
                        aStack.push(Console.ReadLine());
                        break;
                    case 3: aStack.pop();
                        break;
                    case 4: aStack.peek();
                        break;
                    case 5: aStack.display();
                        break;
                    case 6: System.Environment.Exit(1);
                        break;
                }
                Console.ReadKey();
            }
        }

        public void push(object o)
        {
            if (topOfTheStack == (SizeOfTheStack - 1))
                Console.WriteLine("The stack is full, cannot push any more items.");
            else
            {
                myStack[++topOfTheStack] = o;
                Console.WriteLine("The item push success.");
            }
        }

        public object pop()
        {
            if (!IsEmpty())
            {
                Console.WriteLine("Removing top item {0}", myStack[topOfTheStack]);
                return myStack[topOfTheStack--];

            }

            else
                return "Empty Stack, nothing to pop, please push first!";

        }

        public bool IsEmpty()
        {
            if (topOfTheStack == -1)
            {
                Console.WriteLine("The stack is empty!");
                return true;
            }

            else
            {
                Console.WriteLine("The stack is not empty");
                return false;
            }
            
        }

        public object peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty!");
                return "No elements";
            }
            else
            {
                Console.WriteLine(myStack[topOfTheStack]);
                return myStack[topOfTheStack];
            }
                
        }

        public void display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The stack is empty");

            }
            else
            {
                Console.WriteLine("Top of the stack is: {0}", topOfTheStack);
                Console.WriteLine("Your stack values:\n");
                for (int j = topOfTheStack; j > -1; j--)
                    Console.WriteLine("Item {0} is: {1}", j, myStack[j]);
            }
                
        }
    }

}
