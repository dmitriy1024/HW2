using System;

namespace HW2.Arrays.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Original array:");
            foreach (var item in array)
                Console.Write(item + "  ");

            Console.WriteLine();
            int numForAdd = 99;
            int[] arrayWithAddedNum = AddNumToArray(array, numForAdd);

            Console.WriteLine("Array with added number {0}:", numForAdd);
            foreach (var item in arrayWithAddedNum)
                Console.Write(item + "  ");

            Console.ReadKey();
        }

        static int[] AddNumToArray(int[] array, int numForAdd)
        {
            int[] arrForAdd = new int[array.Length + 1];
            array.CopyTo(arrForAdd, 0);
            arrForAdd[arrForAdd.Length - 1] = numForAdd;

            return arrForAdd;
        }
    }
}
