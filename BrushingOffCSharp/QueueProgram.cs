using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushingOffCSharp
{

    public class QueuePrograms
    {
        #region Properties

        /// <summary>
        /// The capacity of the Elements Collection
        /// </summary>
        private int _capacity;
        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }

        /// <summary>
        /// The number of elements currently in the queue.
        /// </summary>
        private int _length;
        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }

        /// <summary>
        /// The actual data elements stored in the queue.
        /// </summary>
        private String[] _elements;
        protected String[] Elements
        {
            get { return _elements; }
            set { _elements = value; }
        }

        /// <summary>
        /// This is the index where we will dequeue.
        /// </summary>
        private int _frontIndex;
        public int FrontIndex
        {
            get { return _frontIndex; }
            set { _frontIndex = value; }
        }

        /// <summary>
        /// This is the index where we will next enqueue a value. 
        /// It is calculated based on the Front Index, Length, and Capacity
        /// </summary>
        public int BackIndex
        {
            get { return (FrontIndex + Length) % Capacity; }
        }

        #endregion

        #region Constructors

        public QueuePrograms()
        {
            Elements = new String[Capacity];
        }

        public QueuePrograms(int capacity)
        {
            Capacity = capacity;
            Elements = new String[Capacity];
        }

        #endregion

        #region public methods

        public void Enqueue(String element)
        {
            if (this.Length == Capacity)
            {
                IncreaseCapacity();
            }
            Elements[BackIndex] = element;
            Length++;

            Console.WriteLine("The value {0} is queued succesfully", element);
        }

        public String Dequeue()
        {
            if (this.Length < 1)
            {
                throw new System.InvalidOperationException("Queue is empty");
            }
            String element = Elements[FrontIndex];
            Console.WriteLine("The value dequeued is: {0}",element);
            Elements[FrontIndex] = default(String);
            Length--;
            FrontIndex = (FrontIndex + 1) % Capacity;
            return element;
        }

        public string PeekIn()
        {
            Console.WriteLine("Value at the front is: {0}", Elements[FrontIndex]);
            return Elements[FrontIndex];
        }

        public String[] DisplayQueue()
        {
            foreach (var a in Elements)
            {
                Console.WriteLine(a);
            }
            return Elements;
        }

        #endregion

        #region protected methods

        protected void IncreaseCapacity()
        {
            this.Capacity++;
            this.Capacity *= 2;
            QueuePrograms tempQueue = new QueuePrograms(this.Capacity);
            while (this.Length > 0)
            {
                tempQueue.Enqueue(this.Dequeue());
            }
            this.Elements = tempQueue.Elements;
            this.Length = tempQueue.Length;
            this.FrontIndex = tempQueue.FrontIndex;
        }

        #endregion


        public void MainForQueue()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nThis is queue operation! Please select an option:");
                Console.WriteLine("1. Queue in value into the queue.");
                Console.WriteLine("2. Dequeue value from the front of the queue.");
                Console.WriteLine("3. Peek the front element of the queue.");
                Console.WriteLine("4. Display all values in the queue.");
                Console.WriteLine("5. Exit.");

                int optionIn = Convert.ToInt32(Console.ReadLine());

                switch (optionIn)
                {
                    case 1:
                        {
                            Console.WriteLine("Please enter the value you wish to push into the stack:");
                            string val = Console.ReadLine();
                            this.Enqueue(val);
                        }
                        break;
                    case 2: this.Dequeue();
                        break;
                    case 3: this.PeekIn();
                        break;
                    case 4: this.DisplayQueue();
                        break;
                    case 5: System.Environment.Exit(1);
                        break;
                }
                Console.ReadKey();
            }
        }
    }

}