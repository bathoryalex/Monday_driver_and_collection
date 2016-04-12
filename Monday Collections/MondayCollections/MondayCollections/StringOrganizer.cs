using System;
using System.Collections;


namespace MondayCollections
{
    class StringOrganizer
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();

            string userInput;

            Console.WriteLine("Add strings! This program will sort them in alphabetical order. \nYou have to hit Enter after every word. When you are done hit Enter two times!");

            while ((userInput = Console.ReadLine()) != "")
            {
                myArrayList.Add(userInput);
            }


            Console.WriteLine("The ArrayList initially contains the following values:");
            PrintValues(myArrayList);

            myArrayList.Sort();

            Console.WriteLine("After sorting:");
            PrintValues(myArrayList);

            Console.ReadLine();
        }

        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.WriteLine("   {0}", obj);
            Console.WriteLine();
        }
    }
}






