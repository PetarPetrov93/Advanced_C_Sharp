namespace _01.ClimbThePeaks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> food = new Stack<int>(Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Queue<int> stamina = new Queue<int>(Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            List<int> peaksDifficulty = new List<int>() { 80, 90, 100, 60, 70};
            List<string> conqueredPeaks = new List<string>();
            bool didNotConquerAll = true;

            while (food.Count > 0 && stamina.Count > 0)
            {
                if (food.Pop() + stamina.Dequeue() >= peaksDifficulty[0])
                {
                    if (peaksDifficulty[0] == 80)
                    {
                        conqueredPeaks.Add("Vihren");
                    }
                    else if (peaksDifficulty[0] == 90)
                    {
                        conqueredPeaks.Add("Kutelo");
                    }
                    else if (peaksDifficulty[0] == 100)
                    {
                        conqueredPeaks.Add("Banski Suhodol");
                    }
                    else if (peaksDifficulty[0] == 60)
                    {
                        conqueredPeaks.Add("Polezhan");
                    }
                    else if (peaksDifficulty[0] == 70)
                    {
                        conqueredPeaks.Add("Kamenitza");
                    }
                    peaksDifficulty.RemoveAt(0);
                    if (conqueredPeaks.Count == 5)
                    {
                        Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
                        didNotConquerAll = false;
                        break;
                    }
                }
            }
            if (didNotConquerAll)
            {
                Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
            }
            if (conqueredPeaks.Count > 0)
            {
                Console.WriteLine("Conquered peaks:");
                foreach (var peak in conqueredPeaks)
                {
                    Console.WriteLine(peak);
                }
            }
        }
    }
}