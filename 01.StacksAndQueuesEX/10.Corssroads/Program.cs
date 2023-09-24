namespace _10.Corssroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLightSec = int.Parse(Console.ReadLine());
            int freeWindowSec = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();
            int counter = 0;
            string car = string.Empty;
            string cmd;

            while ((cmd = Console.ReadLine()) != "END")
            {
                if (cmd == "green" && cars.Any())
                {
                    int greenLight = greenLightSec;
                    int freeWindow = freeWindowSec;
                    
                    Queue<char> currCar = new Queue<char>();
                    
                    while (greenLight > 0 && cars.Any())
                    {
                        car = cars.Peek();
                        if (cars.Peek().Count() <= greenLight)
                        {
                            greenLight -= cars.Dequeue().Count();
                            counter++;
                        }
                        else
                        {
                            foreach (char symbol in cars.Dequeue())
                            {
                                currCar.Enqueue(symbol);
                            }
                            while (greenLight > 0)
                            {
                                if (currCar.Any())
                                {
                                    currCar.Dequeue();
                                    greenLight--;
                                }
                                else
                                {
                                    greenLight = 0;
                                    break;
                                }
                            }                         
                        }
                    }

                    if (currCar.Any())
                    {
                        if (freeWindow < currCar.Count)
                        {
                            for (int i = 0; i < freeWindow; i++)
                            {
                                currCar.Dequeue();
                            }
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{car} was hit at {currCar.Dequeue()}.");
                            return;
                        }
                        else
                        {
                            counter++;
                        }
                    }
                    
                }
                else
                {
                    cars.Enqueue(cmd);
                }
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{counter} total cars passed the crossroads.");
        }
    }
}