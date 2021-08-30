namespace Foschi.airstrip
{
    public abstract class AirStrip: IAirStrip
    {
        /// <summary>
        /// Standard score for a plane
        /// </summary>
        private const int AirplaneScore = 100;

        protected const string StandardUrl = "url_not_initialized";
        /// <summary>
        /// Status of the strip
        /// </summary>
        public AirStripStatus Status { get; set; }
        /// <summary>
        /// Actual score
        /// </summary>
        public int Score { get; set; }
        /// <summary>
        /// Url of the strip
        /// </summary>
        public string Url { get; set; }
        
        public AirStrip()
        {
            this.Status = AirStripStatus.Free;
        }

        public AirStrip(string url) : this()
        {
            this.Url = url;
        }
        /// <inheritdoc />
        public void SetScore(int score)
        {
            this.Score += AirplaneScore;
        }

        /// <summary>
        /// Calculate the area of the strip.
        /// </summary>
        /// <returns>The area itself</returns>
        public abstract double CalculateArea();
    }
}