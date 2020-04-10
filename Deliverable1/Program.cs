using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of trip would you like to go on, musical, tropical, or adventurous ? ");
            string vacationType = Console.ReadLine();

            Console.WriteLine("How many are in your group? ");
            int groupSize = int.Parse(Console.ReadLine());

            string vacationDestination;
                if (vacationType == "Musical") { vacationDestination = " to New Orleans";
            } else 
                if (vacationType == "Tropical") { vacationDestination = " to a beach vacation in Mexico";
            } else { vacationDestination = " to go whitewater rafting the Grand Canyon"; 
            }

            string travelSuggestion;
                if (groupSize <= 2) { travelSuggestion = "fly first class";
            } else
                if (groupSize <= 5) { travelSuggestion = "take a helicoptor";
            } else { travelSuggestion = "take a charter flight";
            }

            string result = "Since you are a group of " + groupSize + " going on a " + vacationType + " vacation, you should " + travelSuggestion + vacationDestination + ".";

            Console.WriteLine(result);




        }
    }
}
