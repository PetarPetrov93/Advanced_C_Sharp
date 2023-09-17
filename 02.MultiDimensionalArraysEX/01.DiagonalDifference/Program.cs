namespace _01.DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] numbers = new int[n,n];
           

            for (int raw = 0; raw < n; raw++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    numbers[raw,col] = input[col];
                }
            }
            int diagonalXSum = 0;
            int diagonalYSum = 0;

            for (int i = 0; i < n; i++)
            {
                diagonalXSum += numbers[i,i];
            }
            for (int i = 0; i < n; i++)
            {
                diagonalYSum += numbers[numbers.GetLength(1) - 1 - i, i];
            }
            Console.WriteLine(Math.Abs(diagonalXSum - diagonalYSum));
        }
    }
}