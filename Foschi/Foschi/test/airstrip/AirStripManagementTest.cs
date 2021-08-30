using System;
using Foschi.airstrip;
using Xunit;

namespace Foschi.test.airstrip
{
    public class AirStripManagementTest
    {
        private const int StripLength = 40;
        private const int StripWidth = 20;
        private const double StripRadius = 12.5;
        private const string MyStripUrl = "Andrea/example.png";
        private const string MyStripUrl2 = "Andrea/example2.png";
        
        private readonly AirStrip _strip1 = new BasicAirStrip(MyStripUrl, StripLength, StripWidth);
        private readonly AirStrip _strip2 = new HelipadAirStrip(MyStripUrl2, StripRadius);

        [Fact]
        public void TestDimension()
        {
            var width = CalculateWidth((BasicAirStrip) _strip1, StripLength);
            Assert.Equal(width, StripWidth);
            var length = CalculateLength((BasicAirStrip) _strip1, StripWidth);
            Assert.Equal(length, StripLength);
            var radius = CalculateRadius((HelipadAirStrip) _strip2);
            Assert.Equal(radius, StripRadius);
        }

        private object CalculateRadius(HelipadAirStrip strip)
        {
            var area = strip.CalculateArea();
            return Math.Sqrt(area/ Math.PI);
        }

        private int CalculateLength(BasicAirStrip strip, int width)
        {
            var area = strip.CalculateArea();
            return (int) (area / width);
        }

        private int CalculateWidth(BasicAirStrip strip, int length)
        {
            var area = strip.CalculateArea();
            return (int) (area / length);
        }
    }
}