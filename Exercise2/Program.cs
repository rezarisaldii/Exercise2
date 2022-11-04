using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static int InsertionSorting()
        {
            Console.Write("\nProgram for sorting a numeric array using Insertion Sorting");
            Console.Write("\n\nEnter number of elements: ");
            int max = Convert.ToInt32(Console.ReadLine());
            int[] reza = new int[27]; //maximum array

            for (int i = 0; i < 27; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                reza[i] = Convert.ToInt32(Console.ReadLine());
            }
            //input array
            Console.Write("Input int array: ");
            for (int k = 0; k < 27; k++)
                Console.Write(reza[k] + " ");
            Console.Write("\n");
            for (int i = 1; i < 27; i++)
            {
                int RR = i;
                while (RR > 0)
                {
                    if (reza[RR - 1] > reza[RR])
                    {
                        int temp = reza[RR - 1];
                        reza[RR - 1] = reza[RR];
                        reza[RR] = temp;
                        RR--;
                    }
                    else
                        break;
                }
                Console.Write("Iteration " + i.ToString() + ": ");
                for (int k = 0; k < 27; k++)
                    Console.Write(reza[k] + " ");
                Console.Write("\n");
                //Console.Write("/*** " + (i + 1).ToString() + " numbers from the beginning of the array are input and they are sorted ***/\n");
            }
            Console.Write("\n\nThe numbers in ascending orders are given below:\n\n");
            for (int i =0; i < 27; i++)
            {
                Console.Write("Sorted [" + (i + 1).ToString() + "] element");
                Console.Write(reza[i]);
                Console.Write("\n");
            }
            return 0;
        }
        static void Main(string[] args)
        {
            InsertionSorting();
            Console.ReadLine();
        }
    }
}
