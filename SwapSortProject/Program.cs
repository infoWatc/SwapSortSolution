//Sort
using System;
using System.Linq;

namespace Sort
{
    class Sort
    {
        // Sorting Methods
        // Ascending 
        public static void Ascending(decimal[] array0)
        {
            for (int i = 0; i <= array0.Length - 1; i++)
            {
                // Temp int variable to hold value in
                decimal key;

                // Swap out adjacent value by order,
                // till completed.
                for (int j = 0; j < array0.Length - 1; j++)
                {
                    if (array0[j] > array0[j + 1])
                    {
                        key = array0[j + 1];
                        array0[j + 1] = array0[j];
                        array0[j] = key;
                    }
                }
            }
        }

        // Descending
        public static void Decending(decimal[] array1)
        {
            for (int i = 0; i <= array1.Length - 1; i++)
            {
                // key int variable to hold value in
                decimal key;

                // Swap out adjacent value by order,
                // till completed.
                for (int j = 0; j < array1.Length - 1; j++)
                {
                    if (array1[j] < array1[j + 1])
                    {
                        key = array1[j + 1];
                        array1[j + 1] = array1[j];
                        array1[j] = key;
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string textNumbers = "91, 2, 53, 77, 32, 523, 231, 12, 42, 32";
            decimal[] decArray = textNumbers.Split(',').Select(d => decimal.Parse(d)).ToArray();
            decimal[] decArray2 = textNumbers.Split(',').Select(d => decimal.Parse(d)).ToArray();
            decimal[] decArray3 = textNumbers.Split(',').Select(d => decimal.Parse(d)).ToArray();
            Console.WriteLine("Ascending Sort   ------------------------>");
            Sort.Ascending(decArray2);

            for (int k = 0; k < decArray.Length; k++)
            {
                Console.Write("original number: " + decArray[k] + "    sorted number: ");
                Console.WriteLine(decArray2[k]);
            }

            Console.WriteLine("Decending Sort   ------------------------>");
            Sort.Decending(decArray3);

            for (int k = 0; k < decArray.Length; k++)
            {
                Console.Write("original number: " + decArray[k] + "    sorted number: ");
                Console.WriteLine(decArray3[k]);
            }
        }


    }
}
