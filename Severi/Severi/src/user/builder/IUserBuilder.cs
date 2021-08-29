namespace Severi.user.builder
{
    public interface IUserBuilder
    {
        /// <summary>
        /// Adds name to user at building.
        /// </summary>
        /// <param name="name"> of the user</param>
        /// <returns>builder</returns>
        IUserBuilder Name(in string name);

        /// <summary>
        /// Adds score to user at building.
        /// </summary>
        /// <param name="score">of the user</param>
        /// <returns>builder</returns>
        IUserBuilder Score(in int score);

        /// <summary>
        /// Builds user by name and score.
        /// </summary>
        /// <returns>user built</returns>
        IUser Build();
    }
}
