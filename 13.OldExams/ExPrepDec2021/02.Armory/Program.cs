using System;

namespace _02.Armory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] armory = new char[n,n];
            int aRow = -1;
            int aCol = -1;

            int m1Row = -1;
            int m1Col = -1;

            int m2Row = -1;
            int m2Col = -1;

            int coinsSpent = 0;

            for (int row = 0; row < n; row++)
            {
                char[] cols = Console.ReadLine().ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    armory[row, col] = cols[col];
                    if (cols[col] == 'A')
                    {
                        aRow = row;
                        aCol = col;
                    }
                    if (cols[col] == 'M')
                    {
                        if (m1Row == -1 && m1Col == -1)
                        {
                            m1Row = row;
                            m1Col = col;
                        }
                        else
                        {
                            m2Row = row;
                            m2Col = col;
                        }
                    }
                    
                }
            }

            bool doneDeal = true;
            while (coinsSpent < 65)
            {
                string cmd = Console.ReadLine();

                if (cmd == "left")
                {
                    armory[aRow, aCol] = '-';
                    if (aCol-1 < 0)
                    {
                        doneDeal = false;
                        Console.WriteLine("I do not need more swords!");
                        break;
                    }
                    aCol--;
                }
                else if (cmd == "right")
                {
                    armory[aRow, aCol] = '-';
                    if (aCol + 1 >= n)
                    {
                        doneDeal = false;
                        Console.WriteLine("I do not need more swords!");
                        break;
                    }
                    aCol++;
                }
                else if (cmd == "up")
                {
                    armory[aRow, aCol] = '-';
                    if (aRow - 1 < 0)
                    {
                        doneDeal = false;
                        Console.WriteLine("I do not need more swords!");
                        break;
                    }
                    aRow--;
                }
                else if (cmd == "down")
                {
                    armory[aRow, aCol] = '-';
                    if (aRow + 1 >= n)
                    {
                        doneDeal = false;
                        Console.WriteLine("I do not need more swords!");
                        break;
                    }
                    aRow++;
                }
                if (armory[aRow, aCol] == 'M')
                {
                    if (aRow == m1Row && aCol == m1Col)
                    {
                        armory[aRow, aCol] = '-';
                        aRow = m2Row;
                        aCol = m2Col;
                    }
                    else if (aRow == m2Row && aCol == m2Col)
                    {
                        armory[aRow, aCol] = '-';
                        aRow = m1Row;
                        aCol = m1Col;
                    }
                }
                else if (char.IsDigit(armory[aRow, aCol]))
                {
                    coinsSpent += int.Parse(armory[aRow, aCol].ToString());
                    armory[aRow, aCol] = '-';
                }
            }
            
            if (doneDeal)
            {
                armory[aRow, aCol] = 'A';
                Console.WriteLine("Very nice swords, I will come back for more!");
            }
            Console.WriteLine($"The king paid {coinsSpent} gold coins.");

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(armory[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
