namespace _06.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> playlist = new Queue<string>(songs);

            while (playlist.Any())
            {
                string command = Console.ReadLine();

                if (command == "Play")
                {
                    playlist.Dequeue();
                }
                else if (command.Contains("Add"))
                {
                    
                    string song = command.Substring(4);

                    if (!playlist.Contains(song))
                    {
                        
                        playlist.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", playlist));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}