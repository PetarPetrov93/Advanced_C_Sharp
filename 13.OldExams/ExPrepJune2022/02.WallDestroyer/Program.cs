using System;

namespace _02.WallDestroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] house = new char[n,n];

            int vankoRow = -1;
            int vankoCol = -1;

            for (int row = 0; row < n; row++)
            {
                char[] cols = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    house[row, col] = cols[col];
                    if (cols[col] == 'V')
                    {
                        vankoRow = row;
                        vankoCol = col;
                    }
                }
            }

            string cmd;
            house[vankoRow, vankoCol] = '*';
            int holesCount = 1;
            int rodsCount = 0;
            bool didntGetElectrified = true;

            while ((cmd = Console.ReadLine()) != "End")
            {
                
                if (cmd == "left")
                {
                    if (vankoCol - 1 < 0)
                    {
                        continue;
                    }
                    if (house[vankoRow, vankoCol-1] == 'R')
                    {
                        Console.WriteLine("Vanko hit a rod!");
                        rodsCount++;
                        continue;
                    }
                    
                    vankoCol--;
                    
                }
                else if (cmd == "right")
                {
                    if (vankoCol + 1 >= n)
                    {
                        continue;
                    }
                    if (house[vankoRow, vankoCol + 1] == 'R')
                    {
                        Console.WriteLine("Vanko hit a rod!");
                        rodsCount++;
                        continue;
                    }
                    
                    vankoCol++;
                }
                else if (cmd == "up")
                {
                    if (vankoRow - 1 < 0)
                    {
                        continue;
                    }
                    if (house[vankoRow - 1, vankoCol] == 'R')
                    {
                        Console.WriteLine("Vanko hit a rod!");
                        rodsCount++;
                        continue;
                    }
                    
                    vankoRow--;
                }
                else if (cmd == "down")
                {
                    if (vankoRow + 1 >= n)
                    {
                        continue;
                    }
                    if (house[vankoRow + 1, vankoCol] == 'R')
                    {
                        Console.WriteLine("Vanko hit a rod!");
                        rodsCount++;
                        continue;
                    }
                    
                    vankoRow++;
                }

                if (house[vankoRow, vankoCol] == 'C')
                {
                    house[vankoRow, vankoCol] = 'E';
                    holesCount++;
                    Console.WriteLine($"Vanko got electrocuted, but he managed to make {holesCount} hole(s).");
                    didntGetElectrified = false;
                    break;
                }
                else if (house[vankoRow, vankoCol] == '*')
                {
                    Console.WriteLine($"The wall is already destroyed at position [{vankoRow}, {vankoCol}]!");
                }
                else if (house[vankoRow, vankoCol] == '-')
                {
                    house[vankoRow, vankoCol] = '*';
                    holesCount++;
                }
            }
            if (didntGetElectrified)
            {
                house[vankoRow, vankoCol] = 'V';
                Console.WriteLine($"Vanko managed to make {holesCount} hole(s) and he hit only {rodsCount} rod(s).");
            }
            
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(house[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
