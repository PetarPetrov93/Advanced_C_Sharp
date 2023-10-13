
using System.Dynamic;

namespace _02.MouseInTheKitchen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(",").Select(int.Parse).ToArray();

            char[,] cupboard = new char[dimensions[0], dimensions[1]];

            int mouseRowIndex = -1;
            int mouseColIndex = -1;

            int trapRowIndex = -1;
            int trapColIndex = -1;

            int cheeseCount = 0;

            for (int row = 0; row < cupboard.GetLength(0); row++)
            {
                char[] colsInput = Console.ReadLine().ToCharArray();

                for (int col = 0; col < cupboard.GetLength(1); col++)
                {
                    cupboard[row, col] = colsInput[col];
                    if (colsInput[col] == 'M')
                    {
                        mouseRowIndex = row;
                        mouseColIndex = col;
                    }
                    else if (colsInput[col] == 'T')
                    {
                        trapRowIndex = row;
                        trapColIndex = col;
                    }
                    else if (colsInput[col] == 'C')
                    {
                        cheeseCount++;
                    }
                }
            }
            string cmd = Console.ReadLine();

            while (true)
            {
                if (cmd == "danger")
                {
                    Console.WriteLine("Mouse will come back later!");
                    break;
                }

                if (cmd == "left")
                {
                    if (mouseColIndex - 1 < 0)
                    {
                        Console.WriteLine("No more cheese for tonight!");
                        break;
                    }
                    if (cupboard[mouseRowIndex, mouseColIndex - 1] != '@')
                    {
                        cupboard[mouseRowIndex, mouseColIndex] = '*';
                        mouseColIndex--;
                    }

                }
                else if (cmd == "right")
                {
                    if (mouseColIndex + 1 >= cupboard.GetLength(1))
                    {
                        Console.WriteLine("No more cheese for tonight!");
                        break;
                    }

                    if (cupboard[mouseRowIndex, mouseColIndex + 1] != '@')
                    {
                        cupboard[mouseRowIndex, mouseColIndex] = '*';
                        mouseColIndex++;
                    }

                }
                else if (cmd == "up")
                {
                    if (mouseRowIndex - 1 < 0)
                    {
                        Console.WriteLine("No more cheese for tonight!");
                        break;
                    }

                    if (cupboard[mouseRowIndex - 1, mouseColIndex] != '@')
                    {
                        cupboard[mouseRowIndex, mouseColIndex] = '*';
                        mouseRowIndex--;
                    }

                    
                }
                else if (cmd == "down")
                {
                    if (mouseRowIndex + 1 >= cupboard.GetLength(0))
                    {
                        Console.WriteLine("No more cheese for tonight!");
                        break;
                    }

                    if (cupboard[mouseRowIndex + 1, mouseColIndex] != '@')
                    {
                        cupboard[mouseRowIndex, mouseColIndex] = '*';
                        mouseRowIndex++;
                    }
   
                }
                if (cupboard[mouseRowIndex, mouseColIndex] == 'T')
                {
                    Console.WriteLine("Mouse is trapped!");
                    cupboard[mouseRowIndex, mouseColIndex] = 'M';
                    break;
                }
                else if (cupboard[mouseRowIndex, mouseColIndex] == '*')
                {
                    cupboard[mouseRowIndex, mouseColIndex] = 'M';
                }
                else if (cupboard[mouseRowIndex, mouseColIndex] == 'C')
                {
                    cheeseCount--;
                    cupboard[mouseRowIndex, mouseColIndex] = 'M';
                    if (cheeseCount == 0)
                    {
                        Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                        break;
                    }
                }

                cmd = Console.ReadLine();
            }

            for (int row = 0; row < cupboard.GetLength(0); row++)
            {
                for (int col = 0; col < cupboard.GetLength(1); col++)
                {
                    Console.Write(cupboard[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}