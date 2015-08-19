using System;

namespace HW2.Arrays.Task1
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
            int[] reversedArray = MyReverse(array);
            Console.WriteLine("Reversed Array:");
            foreach (var item in reversedArray)
                Console.Write(item + "  ");

            Console.ReadKey();
        }

        static int[] MyReverse(int[] arr)
        {
            int[] arrForInvert = new int[arr.Length];
            arr.CopyTo(arrForInvert, 0);
            Array.Reverse(arrForInvert);
            return arrForInvert;
        }
    }
}