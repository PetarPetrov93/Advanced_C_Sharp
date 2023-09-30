namespace _08.Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] numbers = new int[n,n];

            for (int i = 0; i < n; i++)
            {
                int[] rowInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    numbers[i, j] = rowInput[j];
                }
            }

            string[] bombs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < bombs.Length; i++)
            {
                int[] currBomb = bombs[i].Split(",").Select(int.Parse).ToArray();
                int currBombRow = currBomb[0];
                int currBombCol = currBomb[1];

                if (numbers[currBombRow, currBombCol] > 0)
                {
                    if (AreCoordinatesValid(numbers, currBombRow - 1, currBombCol - 1) && numbers[currBombRow - 1, currBombCol - 1] > 0)
                    {
                        numbers[currBombRow - 1, currBombCol - 1] -= numbers[currBombRow, currBombCol];
                    }
                    if (AreCoordinatesValid(numbers, currBombRow - 1, currBombCol) && numbers[currBombRow - 1, currBombCol] > 0)
                    {
                        numbers[currBombRow - 1, currBombCol] -= numbers[currBombRow, currBombCol];
                    }
                    if (AreCoordinatesValid(numbers, currBombRow - 1, currBombCol + 1) && numbers[currBombRow - 1, currBombCol + 1] > 0)
                    {
                        numbers[currBombRow - 1, currBombCol + 1] -= numbers[currBombRow, currBombCol];
                    }
                    if (AreCoordinatesValid(numbers, currBombRow, currBombCol - 1) && numbers[currBombRow, currBombCol - 1] > 0)
                    {
                        numbers[currBombRow, currBombCol - 1] -= numbers[currBombRow, currBombCol];
                    }
                    if (AreCoordinatesValid(numbers, currBombRow, currBombCol + 1) && numbers[currBombRow, currBombCol + 1] > 0)
                    {
                        numbers[currBombRow, currBombCol + 1] -= numbers[currBombRow, currBombCol];
                    }
                    if (AreCoordinatesValid(numbers, currBombRow + 1, currBombCol - 1) && numbers[currBombRow + 1, currBombCol - 1] > 0)
                    {
                        numbers[currBombRow + 1, currBombCol - 1] -= numbers[currBombRow, currBombCol];
                    }
                    if (AreCoordinatesValid(numbers, currBombRow + 1, currBombCol) && numbers[currBombRow + 1, currBombCol] > 0)
                    {
                        numbers[currBombRow + 1, currBombCol] -= numbers[currBombRow, currBombCol];
                    }
                    if (AreCoordinatesValid(numbers, currBombRow + 1, currBombCol + 1) && numbers[currBombRow + 1, currBombCol + 1] > 0)
                    {
                        numbers[currBombRow + 1, currBombCol + 1] -= numbers[currBombRow, currBombCol];
                    }
                    numbers[currBombRow, currBombCol] = 0;
                }
            }
            int aliveCellsCount = 0;
            int aliveCellsSum = 0;
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    if (numbers[row, col] > 0)
                    {
                        aliveCellsCount++;
                        aliveCellsSum += numbers[row, col];
                    }
                }
            }
            Console.WriteLine($"Alive cells: {aliveCellsCount}");
            Console.WriteLine($"Sum: {aliveCellsSum}");
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    Console.Write(numbers[row,col] + " ");
                }
                Console.WriteLine();
            }

        }
        static bool AreCoordinatesValid(int[,] field, int row, int col)
        {
            if ((row >= 0 && row < field.GetLength(0)) && (col >= 0 && col < field.GetLength(1)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}