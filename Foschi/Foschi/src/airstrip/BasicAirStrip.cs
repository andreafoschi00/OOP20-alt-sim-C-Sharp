namespace Foschi.airstrip
{
    public class BasicAirStrip: AirStrip
    {
        /// <summary>
        /// Width of the strip.
        /// </summary>
        public double Width { get; set; }
        /// <summary>
        /// Length of the strip.
        /// </summary>
        public double Length { get; set; }

        public BasicAirStrip(string url, double width, double length): base(url)
        {
            this.Width = width;
            this.Length = length;
        }
        
        public BasicAirStrip(double width, double length): this(StandardUrl, width, length)
        {
            
        }

        /// <inheritdoc />
        public override double CalculateArea()
        {
            return Width * Length;
        }
        
        public override string ToString() => "BasicAirStrip[Width: " + Width + ", Length: " + Length + ", Score: " + 
                                             Score + ", Status: " + Status + "]";
    }
}