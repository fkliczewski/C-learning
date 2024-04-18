﻿using System;
using System.Collections.Generic;

namespace Słownik
{
    class Program
    {
        static Dictionary<string, Currency> GetCurrencies()
        {
            return new Dictionary<string, Currency>
            {
                { "usd", new Currency("usd", "United States, Dollar", 1)},
                { "eur", new Currency("eur", "Euro", 0.83975)},
                { "gbp",  new Currency("gbp", "British Pound", 0.74771)},
                { "cad", new Currency("cad", "Canadian Dollar", 1.30724)},
                { "inr", new Currency("inr", "Indian Rupee", 73.04)},
                { "mxn", new Currency("mxn", "Mexican Peso", 21.7571)}
            };
        }

        static void Main(string[] args)
        {
            Dictionary<string, Currency> currencies = GetCurrencies();
            Console.WriteLine("Check the rate for:");
            string userInput = Console.ReadLine();

            Currency selectedCurrency = currencies[userInput];
            if (currencies.TryGetValue(userInput, out selectedCurrency ))
            {
                Console.WriteLine($"Rate for USD to {selectedCurrency.FullName} is {selectedCurrency.Rate}");
            }
            else
            {
                Console.WriteLine("Currency not found");
            }

            currencies.Remove("usd"); 
            currencies.Add("usd", new Currency("usd", "Dollar", 1));
        }

    }
}