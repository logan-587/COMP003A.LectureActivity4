/*
 * Author: Logan Smith
 * Course: COMP-003A
 * Purpose: Code for Lecture Activity 4
 * Reference: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iterationstatements
 */

namespace COMP003A.LectureActivity4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("For Loop Statement");
            Console.WriteLine("".PadRight(50, '*'));

            //count 0-9
            int limit = 10;

            for (int counter = 0; counter < limit; counter++)
            {
                //this code block will execute every loop
                Console.WriteLine($"\tCurrent Counter: {counter}");
            }


            //**************************************************************
            Console.WriteLine("\n"); //new line
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("For Each Statemnt");
            Console.WriteLine("".PadRight(50, '*'));

            string[] simpleArray = new string[] { "eleifend", "donec", "pretium", "vulputate", "sapien", "nec", "sagittis", "aliquam", "malesuada", "bibendum" };

            foreach(var item in simpleArray)
            {
                Console.WriteLine($"\tCurrent item: {item}");
            }



            //**************************************************************
            Console.WriteLine("\n");
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("Do-While Statement");
            Console.WriteLine("".PadRight(50, '*'));

            int counter2 = 0;

            do
            {
                Console.WriteLine($"\tCurrent counter2: {counter2}");
                counter2++;
            } while (counter2 < 10);



            //**************************************************************
            Console.WriteLine("\n");
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("While Statement");
            Console.WriteLine("".PadRight(50, '*'));

            int counter3 = 0;

            while (counter3 < 20)
            {
                Console.WriteLine($"\tCurrent counter3: {counter3}");
                counter3 += 2;
            }

            //**************************************************************
            Console.WriteLine("\n");
            Console.WriteLine("".PadRight(80, '*'));
            Console.WriteLine("Example For-Loop Program that counts from 1-20 and checks if it is odd or even");
            Console.WriteLine("".PadRight(80, '*'));

            for(int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"\t{i} is: even");
                }
                else
                {
                    Console.WriteLine($"\t{i} is: odd");
                }
            }




        }
    }
}