namespace _06.JaggedArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArr = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                jaggedArr[row] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            for (int row = 0; row < rows-1; row++)
            {
                if (jaggedArr[row].Length == jaggedArr[row+1].Length)
                {
                    for (int col = 0; col < jaggedArr[row].Length; col++)
                    {
                        jaggedArr[row][col] *= 2;
                        jaggedArr[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jaggedArr[row].Length; col++)
                    {
                        jaggedArr[row][col] /= 2;                       
                    }
                    for (int col = 0; col < jaggedArr[row + 1].Length; col++)
                    {
                        jaggedArr[row + 1][col] /= 2;
                    }
                }
            }

            string cmd;
            while ((cmd = Console.ReadLine()) != "End")
            {
                string[] cmdArr = cmd.Split();
                int cmdRow = int.Parse(cmdArr[1]);
                int cmdCol = int.Parse(cmdArr[2]);
                int cmdValue = int.Parse(cmdArr[3]);

                if (cmdArr[0] == "Add" && cmdRow >= 0 && cmdCol >= 0 && jaggedArr.GetLength(0) > cmdRow && jaggedArr[cmdRow].Length > cmdCol ) // GetLength can be changed it with "rows"
                {
                    jaggedArr[cmdRow][cmdCol] += cmdValue;
                }
                else if (cmdArr[0] == "Subtract" && cmdRow >= 0 && cmdCol >= 0 && jaggedArr.GetLength(0) > cmdRow && jaggedArr[cmdRow].Length > cmdCol )
                {
                    jaggedArr[cmdRow][cmdCol] -= cmdValue;
                }
            }
            foreach (int[] currRow in jaggedArr)
            {
                Console.WriteLine(string.Join(" ", currRow));
            }
        }
    }
}