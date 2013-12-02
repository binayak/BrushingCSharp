using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushingOffCSharp
{
    class BoxingAndUnboxing
    {
        // Boxing means to store a value type in an object. Object type is stored in garbage collected heap.
        // Unboxing means to extract out value type from an object.

        public static void mainForBoxUnbox()
        {
            // Here both 42 and true are boxed.
            Console.WriteLine(string.Concat("The answer is: ",42,true));

            List<object> mixedObjects = new List<object>();

            mixedObjects.Add("First");

            for (int j = 0; j < 5; j++)
            {
                mixedObjects.Add(j);
            }

            mixedObjects.Add("Second");

            for (int j = 5; j < 10; j++)
            {
                mixedObjects.Add(j);
            }

            foreach (var o in mixedObjects)
            {
                Console.WriteLine(o);
            }

            var sum = 0;

            for (int k = 1; k < 5; k++)
            {
                // Since the type stored in the list is object type, multiplication operator is not allowed. This requires unboxing. 
                //sum += mixedObjects[k] * mixedObjects[k];

                // Unboxing:
                sum += (int)mixedObjects[k] * (int)mixedObjects[k];

                Console.WriteLine("The value of sum after unboxing is: {0} ", sum);
            }
            Console.WriteLine("The value of sum after unboxing is: {0} ", sum);



        }

    }
}
