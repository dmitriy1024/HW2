using System;

namespace HW2.Loops.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string enteredStr;
            long numOfClients;
            long numOfRoutes;
            while(true)
            {
                Console.WriteLine("Enter number of clients -> (x to exit)");
                enteredStr = Console.ReadLine();

                if (enteredStr == "x")
                    break;
                if(Int64.TryParse(enteredStr, out numOfClients))
                {
                    numOfRoutes = CalcNumOfRoutes(numOfClients);
                    if(numOfRoutes >= 0)
                        Console.WriteLine("Number of routes = {0}", numOfRoutes);
                    else
                        Console.WriteLine("Number of clients is very large or negative! Try again!");
                }
            }
        }

        static long CalcNumOfRoutes(long numOfClients)
        {
            if (numOfClients < 0)
                return -1;
            if (numOfClients == 0)
                return 0;
            if (numOfClients == 1)
                return 1;

            long numOfRoutes = 1;
            do
            {
                try
                {
                    checked { numOfRoutes *= numOfClients--; }
                }
                catch(OverflowException)
                {
                    return -1;
                }
            } while (numOfClients != 1);

            return numOfRoutes;
        }
    }
}
