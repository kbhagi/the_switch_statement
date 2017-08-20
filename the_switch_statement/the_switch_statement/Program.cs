using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_switch_statement
{
    class Program
    {
        static void Main(string[] args)
        {
           string excuse; var today = DayOfWeek.Saturday + 1;

            switch (today)
            {

                case DayOfWeek.Monday:
                    excuse = "I never go to work.";
                    break;
                case DayOfWeek.Tuesday:
                    excuse = "I stay at home.";
                    break;
                case DayOfWeek.Wednesday:
                    excuse = "Work is the last thing on my mind.";
                    break;
                case DayOfWeek.Thursday:
                    excuse = "It's a holiday!";
                    break;
                case DayOfWeek.Friday:
                    excuse = "I detest working on Friday";
                    break;
                case DayOfWeek.Saturday:
                    excuse = "It's much too late to go to work now.";
                    break;
                default:
                    throw new Exception();

            }
            Console.WriteLine(excuse);
            CreateExcuse(DayOfWeek.Sunday);

        }
        static string CreateExcuse(DayOfWeek dayOfWeek)
        {
            Dictionary<DayOfWeek, string> dictionary = new Dictionary<DayOfWeek, string>()
            {
                [DayOfWeek.Monday] = "I never go to work.",
                [DayOfWeek.Tuesday] = "I stay at home.",
                [DayOfWeek.Wednesday] = "Work is the last thing on my mind.",
                [DayOfWeek.Thursday] = "It's a holiday!",
                [DayOfWeek.Friday] = "I detest working on Friday.",
                [DayOfWeek.Saturday] = "It's much too late to go to work now.",
                [DayOfWeek.Sunday] = "Sunday is the day of rest."
            };
            return dictionary[dayOfWeek];
        }
    }
}
