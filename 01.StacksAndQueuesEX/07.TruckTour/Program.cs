namespace _07.TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tank = 0;
            int stationIndex = 0;
            Queue<int[]> allStations = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] station = Console.ReadLine().Split().Select(int.Parse).ToArray();
                
                allStations.Enqueue(station);
            }

            while (true)
            {
                foreach (int[] currStation in allStations)
                {
                    int litres = currStation[0];
                    int distance = currStation[1];
                    if (tank + litres - distance < 0)
                    {
                        tank = 0;
                        break;
                    }
                    else
                    {
                        tank += litres - distance;
                        
                    }
                    
                }
                if (tank > 0)
                {                
                    break;
                }
                stationIndex++;
                allStations.Enqueue(allStations.Dequeue());
            }
            Console.WriteLine(stationIndex);

        }
    }
}