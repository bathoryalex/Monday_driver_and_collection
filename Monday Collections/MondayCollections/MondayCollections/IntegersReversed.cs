using System;
using System.Collections;

namespace MondayCollections
{
    public class IntegersReversed
    {
        public static void IntegersRev()
        {
            Console.WriteLine("Please add some integers. The program will give you back these integers LIFO!");

            Stack stack = new Stack();

            string userInput;

            while (true)
            {
                Console.WriteLine("Input: ");
                userInput = Console.ReadLine();
                if (userInput == "")
                {
                    break;
                }
                else
                { 
                    stack.Push(Convert.ToInt32(userInput));
                }
                
            }

            while (stack.Count > 0)
            {
                object obj = stack.Pop();
                Console.WriteLine("From Stack: {0}", obj);
            }
            Console.ReadLine();
        }
    }
}