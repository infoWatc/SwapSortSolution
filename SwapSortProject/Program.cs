// Insertion Sort
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
            int i, j;
            decimal key;

            for (i = 1; i < array0.Length; i++)
            {
                key = array0[i];
                j = i - 1;

                /* Move elements of array0[0..i-1], that are
                greater than key, to one position ahead
                of their current position */
                while (j >= 0 && array0[j] > key)
                {
                    array0[j + 1] = array0[j];
                    j = j - 1;
                }
                array0[j + 1] = key;
            }
        }

        // Descending
        public static void Decending(decimal[] array1)
        {
            int i, j;
            decimal key;

            for (i = 1; i < array1.Length; i++)
            {
                key = array1[i];
                j = i - 1;

                /* Move elements of array1[0..i-1], that are
                less than key, to one position ahead
                of their current position */
                while (j >= 0 && array1[j] < key)
                {
                    array1[j + 1] = array1[j];
                    j = j - 1;
                }
                array1[j + 1] = key;
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
