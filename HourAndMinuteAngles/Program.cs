using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourAndMinuteAngles
{
    class Program
    {
        static void Main(string[] args)
        {
            FindAngleInTime(2, 15);
        }

        public static void FindAngleInTime(int hours, int minutes)
        {
            double hourDegrees = (hours * 30) + (minutes * 30.0 / 60);
            double minuteDegrees = minutes * 6;

            double difference = Math.Abs(hourDegrees - minuteDegrees);

            if (difference > 180)
            {
                difference = 360 - difference;
            }

            Console.WriteLine($"The angle between hour hand and minute hand is {difference} degrees");
        }
    }
}
