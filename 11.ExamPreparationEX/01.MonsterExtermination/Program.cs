namespace _01.MonsterExtermination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrMonsterArmor = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] arrStrikingImpact = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> monsterArmour = new Queue<int>(arrMonsterArmor);
            Stack<int> strikingImpact = new Stack<int>(arrStrikingImpact);

            int monstersKilled = 0;

            while (monsterArmour.Any() && strikingImpact.Any())
            {
                if (monsterArmour.Peek() == strikingImpact.Peek()) //works!!!
                {
                    monsterArmour.Dequeue();
                    monstersKilled++;
                    strikingImpact.Pop();
                }
                else if (monsterArmour.Peek() < strikingImpact.Peek())
                {
                    int additionalStrikingPower = strikingImpact.Peek() - monsterArmour.Dequeue();
                    monstersKilled++;

                    if (strikingImpact.Count == 1) // works!!!
                    {
                        strikingImpact.Pop();
                        strikingImpact.Push(additionalStrikingPower);
                    }
                    else // works!!!
                    {
                        strikingImpact.Pop();
                        strikingImpact.Push(strikingImpact.Pop() + additionalStrikingPower);
                    }
                    
                }
                else if (monsterArmour.Peek() > strikingImpact.Peek())  //works!!!
                {
                    monsterArmour.Enqueue(monsterArmour.Dequeue() - strikingImpact.Pop());
                }
            }

            if (monsterArmour.Count == 0)
            {
                Console.WriteLine("All monsters have been killed!");
            }
            if (strikingImpact.Count == 0)
            {
                Console.WriteLine("The soldier has been defeated.");
            }
   
            Console.WriteLine($"Total monsters killed: {monstersKilled}");
        }
    }
}