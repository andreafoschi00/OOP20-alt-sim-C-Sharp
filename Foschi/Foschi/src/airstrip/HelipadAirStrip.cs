using System;

namespace Foschi.airstrip
{
    public class HelipadAirStrip: AirStrip
    {
        private const double Pi = 3.14;
        private const int Exponent = 2;
        /// <summary>
        /// Radius of the helipad.
        /// </summary>
        public double Radius { get; set; }

        public HelipadAirStrip(string url, double radius): base(url)
        {
            this.Radius = radius;
        }

        public HelipadAirStrip(double radius) : this(StandardUrl, radius)
        {
            
        }

        /// <inheritdoc />
        public override double CalculateArea()
        {
            return Pi * Math.Pow(Radius, Exponent);
        }
        
        public override string ToString() => "HelipadAirStrip[Radius: " + Radius + ", Score: " + Score + 
                                             ", Status: " + Status + "]";
    }
}