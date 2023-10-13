namespace _02.DeliveryBoy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = inputData[0];
            int cols = inputData[1];
            char[,] block = new char[rows, cols];

            int[] startingPositionB = new int[2];
            int[] currentPositionB = new int[2];

            int[] address = new int[2];
            int[] pizzaHut = new int[2];

            for (int row = 0; row < rows; row++)
            {
                char[] inputCols = Console.ReadLine().ToCharArray();

                for (int col = 0; col < cols; col++)
                {
                    block[row, col] = inputCols[col];
                    if (inputCols[col] == 'B')
                    {
                        startingPositionB[0] = row;
                        startingPositionB[1] = col;
                        currentPositionB[0] = row;
                        currentPositionB[1] = col;
                    }
                    else if (inputCols[col] == 'A')
                    {
                        address[0] = row;
                        address[1] = col;
                    }
                    else if (inputCols[col] == 'P')
                    {
                        pizzaHut[0] = row;
                        pizzaHut[1] = col;
                    }
                }
            }

            string direction = Console.ReadLine();

            bool cancelledDelivery = false;

            while (true)
            {
                
                if (direction == "left")
                {
                    
                    if (currentPositionB[1] - 1 < 0)
                    {
                        Console.WriteLine("The delivery is late. Order is canceled.");
                        cancelledDelivery = true;
                        break;
                    }
                    if (!(block[currentPositionB[0], currentPositionB[1] - 1] == '*'))
                    {
                        currentPositionB[1] -= 1;
                    }
                    
                    
                }
                else if (direction == "right")
                {
                    if (currentPositionB[1] + 1 >= cols)
                    {
                        Console.WriteLine("The delivery is late. Order is canceled.");
                        cancelledDelivery = true;
                        break;
                    }
                    if (!(block[currentPositionB[0], currentPositionB[1] + 1] == '*'))
                    {
                        currentPositionB[1] += 1;
                    }
                    
                }
                else if (direction == "up")
                {
                    if (currentPositionB[0] - 1 < 0)
                    {
                        Console.WriteLine("The delivery is late. Order is canceled.");
                        cancelledDelivery = true;
                        break;
                    }
                    if (!(block[currentPositionB[0] - 1, currentPositionB[1]] == '*'))
                    {
                        currentPositionB[0] -= 1;
                    }
                    
                }
                else if (direction == "down")
                {
                    if (currentPositionB[0] + 1 >= rows)
                    {
                        Console.WriteLine("The delivery is late. Order is canceled.");
                        cancelledDelivery = true;
                        break;
                    }
                    if (!(block[currentPositionB[0] + 1, currentPositionB[1]] == '*'))
                    {
                        currentPositionB[0] += 1;
                    }
                    
                }
                if (!(block[currentPositionB[0], currentPositionB[1]] == 'A') && !(block[currentPositionB[0], currentPositionB[1]] == 'P') && !(block[currentPositionB[0], currentPositionB[1]] == 'R'))
                {
                    block[currentPositionB[0], currentPositionB[1]] = '.';
                }
                else if (block[currentPositionB[0], currentPositionB[1]] == 'P')
                {
                    block[currentPositionB[0], currentPositionB[1]] = 'R';
                    Console.WriteLine("Pizza is collected. 10 minutes for delivery.");

                }
                else if (block[currentPositionB[0], currentPositionB[1]] == 'A' && block[pizzaHut[0], pizzaHut[1]] == 'R')
                {
                    block[currentPositionB[0], currentPositionB[1]] = 'P';
                    Console.WriteLine("Pizza is delivered on time! Next order...");
                    break;
                }

                direction = Console.ReadLine();
            }

            if (cancelledDelivery)
            {
                block[startingPositionB[0], startingPositionB[1]] = ' ';
            }
            else
            {
                block[startingPositionB[0], startingPositionB[1]] = 'B';
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(block[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}