using System.Text.RegularExpressions;
using Severi.user.records;

namespace Severi.user.validation
{
    public class NameQuality
    {
        private const string Pattern = "^[A-Za-z0-9]{1,12}$";
        protected Regex Rgx { get; } = new(Pattern);
        private const int MaxLength = 12;

        private readonly FileOperations _fileOperations = new();

        /// <summary>
        /// Checks name quality based on regex.
        /// </summary>
        /// <param name="name">to check</param>
        /// <returns>name-result enum value</returns>
        public NameResult CheckName(in string name)
        {
            if (string.IsNullOrEmpty(name)
                || string.IsNullOrWhiteSpace(name))
            {
                return NameResult.Empty;
            }

            if (name.Length > MaxLength)
            {
                return NameResult.TooLong;
            }

            if (_fileOperations.IsTaken(name))
            {
                return NameResult.Taken;
            }

            return Rgx.Match(name).Success ? NameResult.Correct : NameResult.Wrong;
        }
    }
}
