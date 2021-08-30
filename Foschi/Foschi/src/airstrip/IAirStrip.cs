namespace Foschi.airstrip
{
    public interface IAirStrip
    {

        /// <summary>
        /// Set the score when a plane lands.
        /// </summary>
        /// <param name="score">The score made when a plane is landed</param>
        void SetScore(int score);
    }
}