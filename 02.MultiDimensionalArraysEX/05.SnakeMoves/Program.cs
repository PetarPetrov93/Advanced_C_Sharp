namespace _05.SnakeMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string word = Console.ReadLine();
            int rows = size[0];
            int cols = size[1];
            char[,] field = new char[rows,cols];
            int wordIndex = 0;          

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        field[row, col] = word[wordIndex];
                        wordIndex++;
                        if (wordIndex == word.Length)
                        {
                            wordIndex = 0;
                        }
                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        field[row, col] = word[wordIndex];
                        wordIndex++;
                        if (wordIndex == word.Length)
                        {
                            wordIndex = 0;
                        }
                    }
                }
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(field[row,col]);
                }
                Console.WriteLine();

            }
        }
    }
}