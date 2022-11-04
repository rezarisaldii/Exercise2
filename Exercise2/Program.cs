using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        //Insertion Sort
        static int InsertionSorting()
        {
            Console.Write("\nProgram for sorting a numeric array using Insertion Sorting");
            int[] reza = new int[27]; //maximum array
            int n;
            while (true)
            {
                Console.Write("\n\ninsert multiple elements in array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 27)
                    break;
                else
                    Console.WriteLine("\nArrays can have a maximum of 27 elements.\n");
            }

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
        //Merge Sort
        static public void MainMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }
            while (left <= eol)
                temp[pos++] = numbers[left++];
            while (mid <= right)
                temp[pos++] = numbers[mid++];
            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
        static public void SortMerge(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge(numbers, left, mid);
                SortMerge(numbers, (mid + 1), right);
                MainMerge(numbers, left, (mid + 1), right);
            }
        }
        static void Main(string[] args)
        {
            Program myList = new Program();
            int pilihanmenu;
            char ch;

            Console.WriteLine("Menu option");
            Console.WriteLine("================");
            Console.WriteLine("1. Insertion Sort");
            Console.WriteLine("2. Merge Sort");
            Console.WriteLine("3. Exit");
            Console.WriteLine("================");
            Console.WriteLine("Enter your choice (1,2,3) : ");
            pilihanmenu = Convert.ToInt32(Console.ReadLine());
            switch (pilihanmenu)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Linear search");
                    Console.WriteLine("----------------------");
                    myList.input();
                    myList.InsertionSorting();
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Binary search");
                    Console.WriteLine("----------------------");
                    myList.input();
                    myList.MainMerge();
                    break;
                case 3:
                    Console.WriteLine("Exit.");
                    break;
                default:
                    Console.WriteLine("error");
                    break;

            }
            InsertionSorting();
            Console.ReadLine();
        }
    }
}
