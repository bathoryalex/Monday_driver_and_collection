using System.Collections.Generic;
using System;

namespace MondayCollections
{
    public class WrittenNumbersToDigits
    {
        public static void wNumToDig()
        {
            Dictionary <string, int> dictionary = new Dictionary<string, int>();

	        dictionary.Add("zero", 0);
            dictionary.Add("one", 1);
	        dictionary.Add("two", 2);
	        dictionary.Add("three", 3);
	        dictionary.Add("four", 4);
	        dictionary.Add("five", 5);
	        dictionary.Add("six", 6);
	        dictionary.Add("seven", 7);
	        dictionary.Add("eight", 8);
	        dictionary.Add("nine", 9);

            string userInput = Console.ReadLine();

            
            foreach (KeyValuePair<string, int> var in dictionary)
            {

                if (userInput.Contains(var.Key))
                {
                    userInput = userInput.Replace(var.Key, var.Value.ToString());
                }
            }

            Console.WriteLine(userInput);

            Console.ReadLine();
        }
    }
}