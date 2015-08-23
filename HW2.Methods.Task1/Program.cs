using System;
using System.Collections.Generic;

namespace HW2.Methods.Task1
{   
    enum Currency{
        USD = 0,
        EUR = 1,
        RUB = 2,
        UAH = 3}

    class Program
    {
        static Dictionary<Currency, double> usdollarExch = new Dictionary<Currency, double>();
        
        static Program()
        {   
            //инициализация курсов относительно доллара
            //предположим, что курсы покупки и продажи одинаковы
            usdollarExch.Add(Currency.USD, 1d);
            usdollarExch.Add(Currency.EUR, 0.9057);
            usdollarExch.Add(Currency.RUB, 65.7220);
            usdollarExch.Add(Currency.UAH, 22.0662);
        } 

        static void Main(string[] args)
        {
            Currency originalCurrency;
            Currency convertToCurrency;
            string enteredString;
            decimal total;

            while(true)
            {
                Console.WriteLine("Enter the currensy like (USD, EUR, RUB, UAH)  (x to exit)");
                enteredString = Console.ReadLine();
                if (enteredString == "x")
                    break;
                if(!Enum.TryParse(enteredString, out originalCurrency))
                {
                    Console.WriteLine("Invalid currency!");
                    continue;
                }

                Console.WriteLine("Enter the total -> (x to exit)");
                enteredString = Console.ReadLine();
                if (enteredString == "x")
                    break;
                if(!Decimal.TryParse(enteredString, out total))
                {
                    Console.WriteLine("Invalid total!");
                    continue;
                }

                Console.WriteLine("Enter the currensy FOR CONVERT TO like (USD, EUR, RUB, UAH)  (x to exit)");
                enteredString = Console.ReadLine();
                if (enteredString == "x")
                    break;
                if (!Enum.TryParse(enteredString, out convertToCurrency))
                {
                    Console.WriteLine("Invalid currency!");
                    continue;
                }

                Console.WriteLine(ConvertCurrency(originalCurrency, total, convertToCurrency));
            }
        }

        static decimal ConvertCurrency(Currency origCurrency, decimal total, Currency convToCurrency)
        {
            double exchange = usdollarExch[origCurrency] * usdollarExch[convToCurrency];
            return total * (decimal)exchange;            
        }
    }
}
