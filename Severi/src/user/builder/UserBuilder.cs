namespace user.builder
{
    public class UserBuilder : IUserBuilder
    {
        private string _name;
        private int _score;

        /// <inheritdoc />
        public IUserBuilder Name(in string name)
        {
            _name = name;
            return this;
        }

        /// <inheritdoc />
        public IUserBuilder Score(in int score)
        {
            _score = score;
            return this;
        }

        /// <inheritdoc />
        public IUser Build() => _name != null ? new User(_name, _score) : null;

        /// <summary>
        /// Builds user by name given at the start.
        /// </summary>
        /// <param name="name">to add to user</param>
        /// <param name="score">to add to user</param>
        /// <returns>built User</returns>
        public static IUser BuildUser(in string name, in int score)
        {
            return new UserBuilder().Name(name).Score(score).Build();
        }
    }
}
