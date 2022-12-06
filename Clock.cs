using System;

namespace Clock
{
    class Clock
    {
        static int calcAngle(int hours, int minutes)
        {
            //Check if negative
            if (hours < 0 || minutes < 0)
                Console.Write("Hours and minutes must be positive");

            //Convert any extra minutes into hours
            if (minutes >= 60)
            {
                hours += minutes / 60;
                minutes %= 60;
            }

            // Calculate the angles moved by hour and minute hands from 00:00
            int hourAngle = (int)(0.5 * (hours * 60 + minutes));
            int minuteAngle = (int)(6 * minutes);

            // Find the difference between two angles
            int angle = Math.Abs(hourAngle - minuteAngle);

            // Find smaller angle of two possible angles
            angle = Math.Min(360 - angle, angle);

            return angle;
        }

        static void Main(string[] args)
        {
            //The program will work with any positive integer for both hours and minutes
            Console.WriteLine("Input hours");
            int hours = int.Parse(Console.ReadLine()) % 12;

            Console.WriteLine("Input minutes");
            int minutes = int.Parse(Console.ReadLine());


            Console.WriteLine("Angle: " + calcAngle(hours, minutes));
        }
    }
}
