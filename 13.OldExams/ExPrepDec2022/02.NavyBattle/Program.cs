namespace _02.NavyBattle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[,] battlefield = new string[n,n];

            int battleshipsDestroyed = 0;
            int minesHit = 0;
            int submarineRowIndex = -1;
            int submarineColIndex = -1;

            for (int row = 0; row < n; row++)
            {
                char[] cols = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    battlefield[row, col] = cols[col].ToString();
                    if (cols[col].ToString() == "S")
                    {
                        submarineRowIndex = row;
                        submarineColIndex = col;
                    }
                }                
            }

            while (true)
            {
                string cmd = Console.ReadLine();

                if (cmd == "left")
                {
                    battlefield[submarineRowIndex, submarineColIndex] = "-";
                    submarineColIndex--;
                    if (battlefield[submarineRowIndex, submarineColIndex] == "*")
                    {
                        minesHit++;
                        
                    }
                    else if (battlefield[submarineRowIndex, submarineColIndex] == "C")
                    {
                        battleshipsDestroyed++;
                    }
                }
                else if (cmd == "right")
                {
                    battlefield[submarineRowIndex, submarineColIndex] = "-";
                    submarineColIndex++;
                    if (battlefield[submarineRowIndex, submarineColIndex] == "*")
                    {
                        minesHit++;

                    }
                    else if (battlefield[submarineRowIndex, submarineColIndex] == "C")
                    {
                        battleshipsDestroyed++;
                    }
                }
                else if (cmd == "up")
                {
                    battlefield[submarineRowIndex, submarineColIndex] = "-";
                    submarineRowIndex--;
                    if (battlefield[submarineRowIndex, submarineColIndex] == "*")
                    {
                        minesHit++;

                    }
                    else if (battlefield[submarineRowIndex, submarineColIndex] == "C")
                    {
                        battleshipsDestroyed++;
                    }
                }
                else if (cmd == "down")
                {
                    battlefield[submarineRowIndex, submarineColIndex] = "-";
                    submarineRowIndex++;
                    if (battlefield[submarineRowIndex, submarineColIndex] == "*")
                    {
                        minesHit++;

                    }
                    else if (battlefield[submarineRowIndex, submarineColIndex] == "C")
                    {
                        battleshipsDestroyed++;
                    }
                }

                if (minesHit == 3)
                {
                    battlefield[submarineRowIndex, submarineColIndex] = "S";
                    Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{submarineRowIndex}, {submarineColIndex}]!");
                    break;
                }
                if (battleshipsDestroyed == 3)
                {
                    battlefield[submarineRowIndex, submarineColIndex] = "S";
                    Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
                    break;
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(battlefield[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}