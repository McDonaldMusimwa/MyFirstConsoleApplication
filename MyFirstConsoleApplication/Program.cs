using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static string name = "McDonald";
        static string location = "Capetown";

        static void Main(string[] args)
        {
            Introduction();

        }
        static void Introduction()
        {
            Console.WriteLine($"My name is {name} , I am from {location}");
            Console.WriteLine($"Today's date: {DateTime.Now.ToString("MM/dd/yyyy")}");

            // Calculate days until Christmas
            DateTime christmas = new DateTime(DateTime.Now.Year, 12, 25);
            int daysUntilChristmas = (int)(christmas - DateTime.Now).TotalDays;
            Console.WriteLine($"Days until Christmas: {daysUntilChristmas}");

            // Add the program example from the C# Programming Yellow Book by Rob Miles
            // (Add the code from section 2.1 as instructed)

            // Pause the console
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
