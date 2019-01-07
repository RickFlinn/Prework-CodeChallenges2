using System;

namespace PreworkChallenges2
{
    class Program
    {
        static void Main(string[] args)
        {
            ProblemOne(1);
            ProblemTwo(4);
        }

        public static void ProblemOne(int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                ArrayMax();
            }
        }

        public static void ProblemTwo(int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                IsLeapYear();
            }
        }
  
        public static void ArrayMax()
        {
            int[] numArr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please input an integer from 1 to 10.");
                numArr[i] = int.Parse(Console.ReadLine());
            }

            string arrMsg = $"Array is [{numArr[0]}";
            for (int i = 1; i < 5; i++)
            {
                arrMsg += $", {numArr[i]}";
            }
            arrMsg += "]. Please input another integer; your score will be the integer * the number of times it occurs in this array.";

            Console.WriteLine(arrMsg);
            int chosenInt = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < 5; i++)
            {
                if (chosenInt == numArr[i])
                {
                    counter++;
                }
            }

            int score = counter * chosenInt;
            Console.WriteLine($"Your score is {score}.");
        }

        public static void IsLeapYear()
        {
            Console.WriteLine("Please input a year as an integer.");
            int yr = int.Parse(Console.ReadLine());
            bool isLeap = (yr % 4 == 0 && (yr % 100 != 0 || yr % 400 == 0));

            if (isLeap)
            {
                Console.WriteLine($"{yr} is a leap year!");
            } else
            {
                Console.WriteLine($"{yr} isn't a leap year.");
            }

        }
    }
}


        
