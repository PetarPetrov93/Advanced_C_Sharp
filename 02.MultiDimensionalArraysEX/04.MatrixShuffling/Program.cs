namespace _04.MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] input = new string[cols];
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmdArr = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (cmdArr[0] != "swap" || cmdArr.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                int indexRow1 = int.Parse(cmdArr[1]);
                int indexCol1 = int.Parse(cmdArr[2]);
                int indexRow2 = int.Parse(cmdArr[3]);
                int indexCol2 = int.Parse(cmdArr[4]);
                if (indexRow1 >= matrix.GetLength(0) || indexRow2 >= matrix.GetLength(0) || indexCol1 >= matrix.GetLength(1) || indexCol2 >= matrix.GetLength(1))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                string firstToSwap = matrix[indexRow1, indexCol1];
                string secondToSwap = matrix[indexRow2, indexCol2];
                matrix[indexRow1, indexCol1] = secondToSwap;
                matrix[indexRow2, indexCol2] = firstToSwap;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i,j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}