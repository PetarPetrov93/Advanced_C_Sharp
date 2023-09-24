namespace _11.KeyRevolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSiize = int.Parse(Console.ReadLine());
            int[] inputBullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inputLocks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int intelligenceValue = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(inputBullets);
            Queue<int> locks = new Queue<int>(inputLocks);

            int bulletsShotPerRound = 0;

            while (bullets.Any() && locks.Any())
            {
                if (bullets.Peek() <= locks.Peek())
                {
                    locks.Dequeue();
                    bullets.Pop();
                    bulletsShotPerRound++;
                    Console.WriteLine("Bang!");


                }
                else
                {
                    bullets.Pop();
                    bulletsShotPerRound++;
                    Console.WriteLine("Ping!");
                }
                if (bulletsShotPerRound == gunBarrelSiize && bullets.Any())
                {
                    bulletsShotPerRound = 0;
                    Console.WriteLine("Reloading!");
                }
            }
            if (!bullets.Any() && locks.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                int totalBulletsShot = inputBullets.Length - bullets.Count;
                int moneyEarned = intelligenceValue - (totalBulletsShot * bulletPrice);
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            }

        }
    }
}