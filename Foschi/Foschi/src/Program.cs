using System;
using Foschi.airstrip;

namespace Foschi
{
    public static class Program
    {
        private const int StripWidth = 150;
        private const int StripLength = 80;
        private const int Strip1InitialScore = 300;
        private const int Strip2InitialScore = 250;
        private const double StripRadius = 33.3;
        private const string MyStripUrl = "Andrea/example.png";
        public static void Main()
        {
            AirStrip strip1 = new BasicAirStrip(MyStripUrl, StripWidth, StripLength);
            AirStrip strip2 = new HelipadAirStrip(StripRadius);

            strip1.Score = Strip1InitialScore;
            strip2.Score = Strip2InitialScore;
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