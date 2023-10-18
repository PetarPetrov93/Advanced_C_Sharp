namespace _01.RubberDuckDebugers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> time = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Stack<int> tasks = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            int darthVaderCount = 0;
            int thorCount = 0;
            int bigBlueRubberCount = 0;
            int smallYellowRubberCount = 0;

            while (time.Count > 0 && tasks.Count > 0)
            {
                if (time.Peek() * tasks.Peek() > 240)
                {
                    time.Enqueue(time.Dequeue());
                    tasks.Push(tasks.Pop() - 2);
                }
                else if (time.Peek() * tasks.Peek() > 0 && time.Peek() * tasks.Peek() <= 60) // could be <= 0, though it doesnt make any sense
                {
                    darthVaderCount++;
                    time.Dequeue();
                    tasks.Pop();
                }
                else if (time.Peek() * tasks.Peek() >= 61 && time.Peek() * tasks.Peek() <= 120) 
                {
                    thorCount++;
                    time.Dequeue();
                    tasks.Pop();
                }
                else if (time.Peek() * tasks.Peek() >= 121 && time.Peek() * tasks.Peek() <= 180) 
                {
                    bigBlueRubberCount++;
                    time.Dequeue();
                    tasks.Pop();
                }
                else if (time.Peek() * tasks.Peek() >= 181 && time.Peek() * tasks.Peek() <= 240) 
                {
                    smallYellowRubberCount++;
                    time.Dequeue();
                    tasks.Pop();
                }
            }
            Console.WriteLine("Congratulations, all tasks have been completed! Rubber ducks rewarded:");

            Console.WriteLine($"Darth Vader Ducky: {darthVaderCount}\nThor Ducky: {thorCount}\nBig Blue Rubber Ducky: {bigBlueRubberCount}\nSmall Yellow Rubber Ducky: {smallYellowRubberCount}");
        }
    }
}