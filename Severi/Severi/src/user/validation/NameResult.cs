namespace Severi.user.validation
{
    public enum NameResult
    {
        /// <summary>
        /// Name is correct.
        /// </summary>
        Correct,

        /// <summary>
        /// Name is empty.
        /// </summary>
        Empty,

        /// <summary>
        /// Name is too long.
        /// </summary>
        TooLong,

        /// <summary>
        /// Name is wrong.
        /// </summary>
        Wrong,

        /// <summary>
        /// Name is taken.
        /// </summary>
        Taken
    }
}
