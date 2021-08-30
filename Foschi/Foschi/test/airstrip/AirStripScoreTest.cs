using Foschi.airstrip;
using Xunit;

namespace Foschi.test.airstrip
{
    public class AirStripScoreTest
    {
        private const int StandardScore = 50;
        private const int InvalidScore = -100;
        private const int StripWidth = 50;
        private const int StripLength = 180;
        private const double StripRadius = 45.3;
        private const int Double = 2;
        private const string MyStripUrl = "Andrea/example.png";
        private const string MyStripUrl2 = "Andrea/example2.png";
        
        private readonly AirStrip _strip1 = new BasicAirStrip(MyStripUrl, StripWidth, StripLength);
        private readonly AirStrip _strip2 = new HelipadAirStrip(MyStripUrl2, StripRadius);

        [Fact]
        public void TestScore()
        {
            _strip1.Score += StandardScore;
            _strip2.Score += StandardScore * Double;
            ResetScore(_strip2);
            Assert.Equal(_strip1.Score, StandardScore);
            Assert.Equal(_strip2.Score, 0);
            if (CheckScore(StandardScore))
            {
                _strip2.Score += StandardScore;
            }

            if (CheckScore(InvalidScore))
            {
                _strip2.Score += InvalidScore;
            }
            Assert.NotEqual(_strip2.Score, StandardScore - InvalidScore);
            Assert.Equal(_strip2.Score, StandardScore);
        }

        private void ResetScore(AirStrip airStrip)
        {
            airStrip.Score = 0;
        }

        private bool CheckScore(int score)
        {
            return score >= 0;
        }
    }
}