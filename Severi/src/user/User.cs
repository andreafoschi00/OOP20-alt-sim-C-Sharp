namespace user
{
    public class User : IUser
    {

        public User(in string name, in int score)
        {
            Name = name;
            Score = score;
        }
        
        /// <inheritdoc />
        public string Name { get; }
        
        /// <inheritdoc />
        public int Score { get; set; }
        
        /// <inheritdoc />
        public void ResetScore()
        {
            Score = 0;
        }

        public override string ToString() => "User[name: " + Name + ", score: " + Score + "]";
    }
}
