namespace _05.ComparingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            List <Person> people = new();

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] inputArr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person person = new(inputArr[0], int.Parse(inputArr[1]), inputArr[2]);
                people.Add(person);
            }
            Person personToCompare = people[int.Parse(Console.ReadLine()) - 1];

            int equalCount = 0;
            int nonEqualCount = 0;

            foreach (Person person in people)
            {
                int result = personToCompare.CompareTo(person);
                if (result == 0)
                {
                    equalCount++;
                }
                else
                {
                    nonEqualCount++;
                }
            }

            if (equalCount == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equalCount} {nonEqualCount} {people.Count}");
            }
        }
    }
}