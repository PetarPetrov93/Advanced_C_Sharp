namespace _05.AppliedArithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Func<List<int>, string, List<int>> calculations = (list, command) => 
            {
                List<int> updatedNums = new List<int>();
                if (command == "add")
                {
                    foreach (int num in list)
                    {
                        updatedNums.Add(num + 1);
                    }
                }
                else if (command == "multiply")
                {
                    foreach (int num in list)
                    {
                        updatedNums.Add(num * 2);
                    }
                }
                else if(command == "subtract")
                {
                    foreach (int num in list)
                    {
                        updatedNums.Add(num - 1);
                    }
                }
                
                return updatedNums;
            };

            Action<List<int>> print = x => Console.WriteLine(string.Join(" ", x));
            
            
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string cmd;

            while ((cmd = Console.ReadLine()) != "end")
            {
                if (cmd == "print")
                {
                    print(numbers);
                }
                else
                {
                    numbers = calculations(numbers, cmd);
                }
            }
        }
    }
}