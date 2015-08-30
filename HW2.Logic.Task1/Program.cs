using System;

namespace HW2.Logic.Task1
{
    class Program
    {
        static void Main(string[] args)
        {            
            string enteredSalary, enteredExp, enteredStr;
            decimal parsedSalary;
            double parsedExp;
            int indexOfSpace;

            while(true)
            {
                Console.WriteLine("Enter the salary and experience with SPACE AS SEPARATOR (x to exit)->");
                enteredStr = Console.ReadLine();

                if (enteredStr == "x")
                    break;

                enteredStr.Trim();

                indexOfSpace = enteredStr.IndexOf(' ');
                if(indexOfSpace != -1)
                {
                    enteredSalary = enteredStr.Substring(0, indexOfSpace);
                    enteredExp = enteredStr.Substring(indexOfSpace + 1);

                    if(Decimal.TryParse(enteredSalary, out parsedSalary) && Double.TryParse(enteredExp, out parsedExp))                    
                        Console.WriteLine("Premium = {0}", CalculatePremium(parsedSalary, parsedExp));                                            
                }
            }
        }

        static decimal CalculatePremium(decimal salary, double exp)
        {
            decimal premium = 0;
            if (exp > 0 && exp < 5)
                premium = salary * 0.1m;
            else if (exp < 10)
                premium = salary * 0.15m;
            else if (exp < 15)
                premium = salary * 0.25m;
            else if (exp < 20)
                premium = salary * 0.35m;
            else if (exp < 25)
                premium = salary * 0.45m;
            else
                premium = salary * 0.5m;

            return premium;
        }
    }
}
