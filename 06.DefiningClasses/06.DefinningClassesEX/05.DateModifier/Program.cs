using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
           DateTime date1 = DateTime.Parse(Console.ReadLine());
           DateTime date2 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine(DateModifier.DaysDifference(date1, date2));

        }
    }
}