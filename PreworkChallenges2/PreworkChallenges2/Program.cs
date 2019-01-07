using System;

namespace PreworkChallenges2
{
    class Program
    {
        static void Main(string[] args)
        {
            ProblemOne(1);
            ProblemTwo(4);
            ProblemThree();
            ProblemFour();
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

        public static void ProblemThree()
        {
            int[][] testArrays = new int[][]
            {
                new int[] {2, 2},
                new int[] {1, 2, 3},
                new int[] {1, 0, -1},
                new int[] {0, 0, 0, 0},
                new int[] {1, 2}
            };

            for (int i = 0; i < testArrays.Length; i++)
            {
                Console.WriteLine(IsPerfectSeq(testArrays[i]));
            }
        }

        public static void ProblemFour()
        {
            Console.WriteLine("Sorry, too lazy to print out the whole matrix, but here are the sums of its rows.");
            int[,] testArrays1 = new int[3, 5] 
            { 
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15 }
            };

            int[] sums = SumOfRows(testArrays1);
            string sumsString = $"[{sums[0]}";
            for (int i = 1; i < sums.Length; i++)
            {
                sumsString += ", " + sums[i];
            }
            sumsString += "]";
            Console.WriteLine(sumsString);

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

        public static string IsPerfectSeq (int[] arr)
        {
            string arrString = "";
            arrString += arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                arrString += ", " + arr[i];
            }

            Console.WriteLine($"Is [{arrString}] a perfect sequence?");
            int sum = arr[0];
            int prod = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    return "No";
                }
                sum += arr[i];
                prod *= arr[i];
            }

            if (sum == prod)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }

        public static int[] SumOfRows (int[,] arrays)
        {
            int[] sums = new int[arrays.GetLength(0)];
            for (int i = 0; i < arrays.GetLength(0); i++)
            {
                for (int j = 0; j < arrays.GetLength(1); j++)
                {
                    sums[i] += arrays[i,j];
                }
            }
            return sums;
        }
    }
}


        
