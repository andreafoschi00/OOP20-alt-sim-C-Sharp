using System.Text.RegularExpressions;
using Severi.user.validation;

namespace Severi.test
{
    public class NameChecker : NameQuality
    {
        private const int MaxLength = 12;

        private readonly FileOperationsTest _fileOperations = new ();
        
        public new NameResult CheckName(in string name)
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