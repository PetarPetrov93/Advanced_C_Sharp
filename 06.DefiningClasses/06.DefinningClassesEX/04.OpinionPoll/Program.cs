using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>(); 
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string name = input.Split()[0];
                int age = int.Parse(input.Split()[1]);

                Person person = new Person(name, age);
                people.Add(person);              
            }
            foreach (var member in people.Where(p => p.Age > 30).OrderBy(n => n.Name))
            {
                Console.WriteLine(member.Name + " - " + member.Age);
            }
                
         
        }
    }
}