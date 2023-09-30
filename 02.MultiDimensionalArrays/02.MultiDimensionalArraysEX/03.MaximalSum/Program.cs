namespace _03.MaximalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int[,] numbers = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] colNums = new int[cols];
                colNums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int j = 0; j < cols; j++)
                {
                    numbers[i, j] = colNums[j];
                }
            }
            int sum = 0;
            int largestSum = int.MinValue;
            int rowIndex = 0;
            int colIndex = 0;

            for (int i = 0; i < rows-2; i++)
            {
                for (int j = 0; j < cols-2; j++)
                {

                    //sum = numbers[i, j] + numbers[i, j+1] + numbers[i, j+2] + 
                    //      numbers[i+1, j] + numbers[i+1, j+1] + numbers[i+1, j+2] + 
                    //      numbers[i+2, j] + numbers[i+2, j+1] + numbers[i+2, j+2];
                    // The above can be replaced by the below 2 for cycles:

                    for (int k = i; k < i+3 ; k++)
                    {
                        for (int l = j; l < j+3; l++)
                        {
                            sum += numbers[k, l];
                        }
                    }

                    if (largestSum < sum)
                    {
                        rowIndex = i;
                        colIndex = j;
                        largestSum = sum;
                    }
                    sum = 0;
                }
            }
            int[,] largestSumNums = new int[3, 3];
            for (int i = 0; i < largestSumNums.GetLength(0);i++)
            {
                for (int j = 0; j < largestSumNums.GetLength(1); j++)
                {
                    largestSumNums[i, j] = numbers[rowIndex + i, colIndex + j];
                }
            }

            Console.WriteLine($"Sum = {largestSum}");
            for (int i = 0; i < largestSumNums.GetLongLength(0); i++)
            {
                for (int j = 0; j < largestSumNums.GetLongLength(1); j++)
                {
                    Console.Write(largestSumNums[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}