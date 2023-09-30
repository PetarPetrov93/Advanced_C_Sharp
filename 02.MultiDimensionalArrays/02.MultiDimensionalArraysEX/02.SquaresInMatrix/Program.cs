namespace _02.SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];

            char[,] symbols = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                char[] input = new char[cols]; 
                    
                    input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    symbols[row, col] = input[col];
                }
            }

            int counter = 0;

            for (int row = 0; row < symbols.GetLength(0)-1; row++)
            {
                for (int col = 0; col < symbols.GetLength(1)-1; col++)
                {
                    if (symbols[row, col] == symbols[row, col+1] && symbols[row,col] == symbols[row + 1, col] && symbols[row,col] == symbols[row+1, col+1])
                    {
                        counter++;
                    }
                }
            }
                       
             Console.WriteLine(counter);
                      
        }
    }
}