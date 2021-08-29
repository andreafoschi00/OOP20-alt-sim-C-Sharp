using System;

namespace Severi.user.score
{
    public static class Score
    {
        public static int GenerateRandomScore()
        {
            var random = new Random();
            var score = random.Next(0, 3001);
            var steps = Math.Floor(score / 100.0);
            var adjustedScore = steps * 100.0;

            return (int)adjustedScore;
        }
    }
}
