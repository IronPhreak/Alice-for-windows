using System;
using System.IO;
using System.Threading.Tasks;

namespace Alice_For_Windows
{
    internal class Reminder
    {
        public static void setup()
        {
            Task T = new Task(() =>
            {
                Console.WriteLine("Starting Time Monitor");
                time_Monitor();
            });
            T.Start();
        }

        private static void time_Monitor()
        {
            while (true)
            {
                DateTime dt = DateTime.Now;
                int hour = dt.Hour;
                int min = dt.Minute;
                int day = dt.Day;
                int month = dt.Month;
                int year = dt.Year;
                Task.Delay(60000).Wait();
            }
        }

        private static void reminder_check(int hour, int min, int day, int month, int year)
        {
            if (!File.Exists("//Files/Reminder.txt"))
            {
                Directory.CreateDirectory("//Files");
                File.CreateText("//Files/Reminder.txt");
            }
            if (File.Exists("//Files/Reminder.txt"))
            {
            }
        }

        public static void setReminder()
        {
            /*
            Reminder needs
            Date:
            Day
            Month
            Year

            Time:
            Hour
            Minute

            Details:
            Title
            Description
            Location (optional)

            Day/Month/Year|Hour|Minute|Title|Description|Location
            Example:
            13/12/2016|12:00| My Birthday|It's my birthday|Home
            */
            string time;
            Console.Write("When shall I remind you? (Format dd/mm/yy)");
            string date = Console.ReadLine();
            Console.Write("Is this an all day event? (y/n)");
            string result = Console.ReadLine();
            if (result == "n")
            {
                Console.Write("What time will this event happen? (Format hh:mm)");
                time = Console.ReadLine();
            }
            else
            {
                time = "00:00";
            }
            Console.Write("What's the title for this event");
            string title = Console.ReadLine();
            Console.Write("Description? (optional)");
            string description = Console.ReadLine();
            Console.Write("Location?");
            string location = Console.ReadLine();

            Console.WriteLine(date + " " + time + " " + title + " " + description + " " + location);
        }
    }
}