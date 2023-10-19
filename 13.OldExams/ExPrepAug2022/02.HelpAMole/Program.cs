using System;

namespace _02.HelpAMole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[,] field = new string[n, n];

            int points = 0;

            int moleRowIndex = -1;
            int moleColIndex = -1;

            int s1RowIndex = -1;
            int s1ColIndex = -1;

            int s2RowIndex = -1;
            int s2ColIndex = -1;

            int sCount = 0;

            for (int row = 0; row < n; row++)
            {
                char[] cols = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    field[row, col] = cols[col].ToString();
                    if (cols[col].ToString() == "M")
                    {
                        moleRowIndex = row;
                        moleColIndex = col;
                    }
                    else if (cols[col].ToString() == "S" && sCount == 0)
                    {
                        s1RowIndex = row;
                        s1ColIndex = col;
                        sCount++;
                    }
                    else if (cols[col].ToString() == "S" && sCount == 1)
                    {
                        s2RowIndex = row;
                        s2ColIndex = col;
                    }
                }
            }

            string cmd;

            while ((cmd = Console.ReadLine()) != "End")
            {
                if (cmd == "left")
                {
                    if (moleColIndex - 1 < 0)
                    {
                        Console.WriteLine("Don't try to escape the playing field!");
                        continue;
                    }
                    field[moleRowIndex, moleColIndex] = "-";
                    moleColIndex--;
                }
                else if (cmd == "right")
                {
                    if (moleColIndex + 1 >= n)
                    {
                        Console.WriteLine("Don't try to escape the playing field!");
                        continue;
                    }
                    field[moleRowIndex, moleColIndex] = "-";
                    moleColIndex++;
                }
                else if (cmd == "up")
                {
                    if (moleRowIndex - 1 < 0)
                    {
                        Console.WriteLine("Don't try to escape the playing field!");
                        continue;
                    }
                    field[moleRowIndex, moleColIndex] = "-";
                    moleRowIndex--;
                }
                else if (cmd == "down")
                {
                    if (moleRowIndex + 1 >= n)
                    {
                        Console.WriteLine("Don't try to escape the playing field!");
                        continue;
                    }
                    field[moleRowIndex, moleColIndex] = "-";
                    moleRowIndex++;
                }
                if (field[moleRowIndex, moleColIndex] == "S")
                {
                    if (moleRowIndex == s1RowIndex && moleColIndex == s1ColIndex)
                    {
                        field[moleRowIndex, moleColIndex] = "-";
                        moleRowIndex = s2RowIndex;
                        moleColIndex = s2ColIndex;
                    }
                    else if (moleRowIndex == s2RowIndex && moleColIndex == s2ColIndex)
                    {
                        field[moleRowIndex, moleColIndex] = "-";
                        moleRowIndex = s1RowIndex;
                        moleColIndex = s1ColIndex;
                    }
                    points -= 3;
                }
                else if (field[moleRowIndex, moleColIndex] != "-")
                {
                    points += int.Parse(field[moleRowIndex, moleColIndex]);
                    if (points >= 25)
                    {
                        break;
                    }
                }
            }
            field[moleRowIndex, moleColIndex] = "M";
            if (points >= 25)
            {
                Console.WriteLine("Yay! The Mole survived another game!");
                Console.WriteLine($"The Mole managed to survive with a total of {points} points.");
            }
            else
            {
                Console.WriteLine("Too bad! The Mole lost this battle!");
                Console.WriteLine($"The Mole lost the game with a total of {points} points.");
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(field[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}