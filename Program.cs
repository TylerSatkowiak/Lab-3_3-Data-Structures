using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace Lab_3_3_Data_Structures
{
    class Program
    {
        static void Main()
        {
            Stack<char> stack = new Stack<char>();
            bool isValid = true;
            while (isValid)
            {

                Console.WriteLine("Type here to have your message reversed:");
                string entry = Console.ReadLine();
                char[] chararray = entry.ToCharArray();
                for (int i = 0; i < entry.Length; i++)
                {
                    char letter = entry[i];
                    stack.Push(letter);
                }

                foreach (char letter in stack)
                {
                    Console.Write(letter);
                }

                Console.WriteLine("");
                Console.WriteLine("Press 'q' to quit, else any other button to return.");
                string checkout = Console.ReadLine().ToLower();
                if (checkout == "q")
                {
                    System.Environment.Exit(1);
                }
                else
                {
                    Main();
                }
            } 
        }
        /*
        static void Calculate(char args)
        {
            Console.WriteLine($"The calculator monster eats your puny words: ");
            
            for (int i = 0; i < myword.Length; i++)
            {
                char letter = myword[i];
                Console.WriteLine(letter);
            }
            
            Console.WriteLine(Calculate(args));
           */
     
    }
}
