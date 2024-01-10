namespace _02.TheGambler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] board = new char[n, n];

            int gamblerRow = -1;
            int gamblerCol = -1;

            int profit = 100;


            for (int row = 0; row < n; row++)
            {
                char[] cols = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    board[row,col] = cols[col];

                    if (cols[col] == 'G')
                    {
                        gamblerRow = row;
                        gamblerCol = col;
                    }
                }
            }

            string cmd;

            while ((cmd = Console.ReadLine()) != "end")
            {
                if (cmd == "left")
                {
                    if (gamblerCol - 1 < 0)
                    {
                        
                        Console.WriteLine("Game over! You lost everything!");
                        return;
                    }
                    board[gamblerRow, gamblerCol] = '-';
                    gamblerCol--;
                }
                else if (cmd == "right")
                {
                    if (gamblerCol + 1 >= n)
                    {

                        Console.WriteLine("Game over! You lost everything!");
                        return;
                    }
                    board[gamblerRow, gamblerCol] = '-';
                    gamblerCol++;
                }
                else if (cmd == "up")
                {
                    if (gamblerRow - 1 < 0)
                    {
                        
                        Console.WriteLine("Game over! You lost everything!");
                        return;
                    }
                    board[gamblerRow, gamblerCol] = '-';
                    gamblerRow--;
                }
                else if (cmd == "down")
                {
                    if (gamblerRow + 1 >= n)
                    {

                        Console.WriteLine("Game over! You lost everything!");
                        return;
                    }
                    board[gamblerRow, gamblerCol] = '-';
                    gamblerRow++;
                }

                if (board[gamblerRow, gamblerCol] == 'W')
                {
                    profit += 100;
                }
                else if (board[gamblerRow, gamblerCol] == 'J')
                {
                    profit += 100_000;
                    Console.WriteLine("You win the Jackpot!");
                    break;
                }
                else if (board[gamblerRow, gamblerCol] == 'P')
                {
                    profit -= 200;
                    if (profit <= 0)
                    {
                        Console.WriteLine("Game over! You lost everything!");
                        return;
                    }
                }
            }

            board[gamblerRow, gamblerCol] = 'G';
            Console.WriteLine($"End of the game. Total amount: {profit}$");

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(board[row, col]);
                }
                Console.WriteLine();
            }


        }
    }
}
