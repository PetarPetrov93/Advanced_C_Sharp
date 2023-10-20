using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;

namespace _02.BeaverAtWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[,] pond = new string[n,n];

            int beaverRow = -1;
            int beaverCol = -1;
            int woodsToCollect = 0;

            for (int row = 0; row < n; row++)
            {
                string[] cols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < n; col++)
                {
                    pond[row, col] = cols[col];
                    if (cols[col] == "B")
                    {
                        beaverRow = row;
                        beaverCol = col;
                    }
                    if (char.IsLower(char.Parse(cols[col])))
                    {
                        woodsToCollect++;
                    }
                }
            }
            List<string> collectedBrunches = new List<string>();
            string cmd;
            bool collectedAllWoods = false;

            while ((cmd = Console.ReadLine()) != "end")
            {
                if (cmd == "left")
                {
                    if (beaverCol - 1 < 0)
                    {
                        if (collectedBrunches.Count > 0)
                        {
                            collectedBrunches.RemoveAt(collectedBrunches.Count-1);
                        }
                        continue;
                    }
                    pond[beaverRow, beaverCol] = "-";
                    beaverCol--;
                }
                else if (cmd == "right")
                {
                    if (beaverCol + 1 >= n)
                    {
                        if (collectedBrunches.Count > 0)
                        {
                            collectedBrunches.RemoveAt(collectedBrunches.Count - 1);
                        }
                        continue;
                    }
                    pond[beaverRow, beaverCol] = "-";
                    beaverCol++;
                }
                else if (cmd == "up")
                {
                    if (beaverRow - 1 < 0)
                    {
                        if (collectedBrunches.Count > 0)
                        {
                            collectedBrunches.RemoveAt(collectedBrunches.Count - 1);
                        }
                        continue;
                    }
                    pond[beaverRow, beaverCol] = "-";
                    beaverRow--;
                }
                else if (cmd =="down")
                {
                    if (beaverRow + 1 >= n)
                    {
                        if (collectedBrunches.Count > 0)
                        {
                            collectedBrunches.RemoveAt(collectedBrunches.Count - 1);
                        }
                        continue;
                    }
                    pond[beaverRow, beaverCol] = "-";
                    beaverRow++;
                }
                if (char.IsLower(char.Parse(pond[beaverRow, beaverCol])))
                {
                    collectedBrunches.Add(pond[beaverRow, beaverCol]);
                    woodsToCollect--;

                    if (woodsToCollect == 0)
                    {
                        collectedAllWoods = true;
                        break;
                    }
                    pond[beaverRow, beaverCol] = "-";
                }
                else if (pond[beaverRow,beaverCol] == "F")
                {
                    pond[beaverRow, beaverCol] = "-";
                    if (cmd == "left")
                    {
                        if (beaverCol == 0)
                        {
                            beaverCol = n - 1;
                        }
                        else
                        {
                            beaverCol = 0;
                        }
                    }
                    else if (cmd == "right")
                    {
                        if (beaverCol == n-1)
                        {
                            beaverCol = 0;
                        }
                        else
                        {
                            beaverCol = n-1;
                        }
                    }
                    else if (cmd == "up")
                    {
                        if (beaverRow == 0)
                        {
                            beaverRow = n - 1;
                        }
                        else
                        {
                            beaverCol = 0;
                        }
                    }
                    else if (cmd == "down")
                    {
                        if (beaverRow == n-1)
                        {
                            beaverRow = 0;
                        }
                        else
                        {
                            beaverCol = n -1;
                        }
                    }
                    if (char.IsLower(char.Parse(pond[beaverRow, beaverCol])))
                    {
                        collectedBrunches.Add(pond[beaverRow, beaverCol]);
                        woodsToCollect--;

                        if (woodsToCollect == 0)
                        {
                            collectedAllWoods = true;
                            break;
                        }
                        pond[beaverRow, beaverCol] = "-";
                    }
                }

            }
            pond[beaverRow, beaverCol] = "B";
            if (collectedAllWoods)
            {
                Console.WriteLine($"The Beaver successfully collect {collectedBrunches.Count} wood branches: {string.Join(", ", collectedBrunches)}.");
            }
            else
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {woodsToCollect} branches left.");
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(pond[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
