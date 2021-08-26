namespace user
{
    public interface IUser
    {
        /// <summary>
        /// Gets user name.
        /// </summary>
        /// <returns>user name</returns>
        string Name { get; }

        /// <summary>
        /// Gets/sets user score.
        /// </summary>
        int Score { get; set; }

        /// <summary>
        /// Resets user score.
        /// </summary>
        void ResetScore();
    }
}
