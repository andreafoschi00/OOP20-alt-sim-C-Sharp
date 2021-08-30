using System;
using Foschi.airstrip;

namespace Foschi
{
    public static class Program
    {
        public static void Main()
        {
            AirStrip strip1 = new BasicAirStrip("Andrea/example.png", 150, 80);
            AirStrip strip2 = new HelipadAirStrip(33.3);

            strip1.Score = 300;
            strip2.Score = 250;
            strip1.Status = AirStripStatus.Busy;
            strip2.Status = AirStripStatus.Disabled;
            Console.WriteLine("First strip url:{0}, second strip url:{1}", strip1.Url, strip2.Url);
            Console.WriteLine("First strip score:{0}, second strip score:{1}", strip1.Score, strip2.Score);
            Console.WriteLine("First strip status:{0}, second strip status:{1}", strip1.Status, strip2.Status);
            Console.WriteLine("BasicAirStrip area:{0}, HelipadAirStrip area:{1}", strip1.CalculateArea(), strip2.CalculateArea());
            Console.WriteLine("{0}, {1}", strip1, strip2);
        }
    }
}