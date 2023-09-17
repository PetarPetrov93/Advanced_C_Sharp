namespace _09.SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<string> stack = new Stack<string>();
            string wordToManipulate = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split();
                if (cmd[0] == "1")
                {
                    stack.Push(wordToManipulate);
                    wordToManipulate += cmd[1];
                }
                else if (cmd[0] == "2")
                {
                    stack.Push(wordToManipulate);
                    int count = int.Parse(cmd[1]);
                    wordToManipulate = wordToManipulate.Substring(0, wordToManipulate.Length - count);
                }
                else if (cmd[0] == "3")
                {
                    
                    int index = int.Parse(cmd[1]) - 1;
                    Console.WriteLine(wordToManipulate[index]);
                }
                else if (cmd[0] == "4" && stack.Any())
                {
                    wordToManipulate = stack.Pop();
                }

            }
        }
    }
}