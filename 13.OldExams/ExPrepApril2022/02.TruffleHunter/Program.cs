using System;
using System.Security.Cryptography;

namespace _02.TruffleHunter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[,] field = new string[n, n];

            for (int row = 0; row < n; row++)
            {
                string[] cols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < n; col++)
                {
                    field[row, col] = cols[col];
                }
            }

            int blackCount = 0;
            int summerCount = 0;
            int whiteCount = 0;
            int eatenTrufflesCount = 0;

            string input;
            while ((input = Console.ReadLine()) != "Stop the hunt")
            {
                string[] inputArr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (inputArr[0] == "Collect")
                {
                    int row = int.Parse(inputArr[1]);
                    int col = int.Parse(inputArr[2]);

                    if ((row >= 0 && row < n) && (col >= 0 && col < n))
                    {
                        if (field[row, col] == "B")
                        {
                            blackCount++;
                            field[row, col] = "-";
                        }
                        else if (field[row, col] == "S")
                        {
                            summerCount++;
                            field[row, col] = "-";
                        }
                        else if (field[row, col] == "W")
                        {
                            whiteCount++;
                            field[row, col] = "-";
                        }
                    }
                }
                else if (inputArr[0] == "Wild_Boar")
                {
                    int row = int.Parse(inputArr[1]);
                    int col = int.Parse(inputArr[2]);
                    string direction = inputArr[3];

                    int boarSteps = 0;

                    if (direction == "right")
                    {
                        for (int i = col; i < n; i++)
                        {
                            if (boarSteps % 2 == 0)
                            {
                                if (field[row, i] != "-")
                                {
                                    eatenTrufflesCount++;
                                    field[row, i] = "-";
                                }
                            }
                            boarSteps++;
                        }
                    }
                    else if (direction == "left")
                    {
                        for (int i = col; i >= 0; i--)
                        {
                            if (boarSteps % 2 == 0)
                            {
                                if (field[row, i] != "-")
                                {
                                    eatenTrufflesCount++;
                                    field[row, i] = "-";
                                }
                            }
                            boarSteps++;
                        }
                    }
                    else if (direction == "up")
                    {
                        for (int i = row; i >= 0; i--)
                        {
                            if (boarSteps % 2 == 0)
                            {
                                if (field[i, col] != "-")
                                {
                                    eatenTrufflesCount++;
                                    field[i, col] = "-";
                                }
                            }
                            boarSteps++;
                        }
                    }
                    else if (direction == "down")
                    {
                        for (int i = row; i < n; i++)
                        {
                            if (boarSteps % 2 == 0)
                            {
                                if (field[i, col] != "-")
                                {
                                    eatenTrufflesCount++;
                                    field[i, col] = "-";
                                }
                            }
                            boarSteps++;
                        }

                    }
                    boarSteps = 0;
                }
            }
            Console.WriteLine($"Peter manages to harvest {blackCount} black, {summerCount} summer, and {whiteCount} white truffles.");
            Console.WriteLine($"The wild boar has eaten {eatenTrufflesCount} truffles.");

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write($"{field[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}