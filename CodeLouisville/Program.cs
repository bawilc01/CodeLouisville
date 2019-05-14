using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int runningTotal = 0;
            bool keepGoing = true;

            while (keepGoing)
            {
                // Prompt user for minutes exercised
                Console.Write("Enter how many minutes you exercised: ");
                string entry = Console.ReadLine();

                if (entry.ToUpper() == "Q")
                {
                    keepGoing = false;

                }
                else
                {

                    // Add minutes exercised to total
                    int minutes = int.Parse(entry);
                    try
                    {
                    }
                    catch (
                    )
                    {
                    }

                    if (minutes <= 0)
                    {
                        Console.WriteLine(minutes + " is not an acceptable value.");
                        continue;
                    }
                    else if (minutes <= 10)
                    {
                        Console.WriteLine("Better than nothing, am I right?");
                    }
                    else if (minutes <= 30)
                    {
                        Console.WriteLine("Way to go hot stuff!");
                    }
                    else if (minutes <= 60)
                    {
                        Console.WriteLine("You must be a ninja warrior in training!");
                    }
                    else
                    {
                        Console.WriteLine("Okay, now you're just showing off!");
                    }

                    runningTotal = runningTotal + minutes;


                    // Display total minutes exercised to the screen
                    Console.WriteLine($"You've exercised a total of {runningTotal} minutes. Press Q to quit.");

                }
            }

            Console.WriteLine("Goodbye!");
            Console.ReadKey();

        }
    }
}

