using System;
using System.IO;

namespace common
{
    /// <summary>
    /// Gets system dependent se
    /// </summary>
    public static class OsDependent
    {
        /// Gets OS file separator.
        public static readonly char Separator = Path.DirectorySeparatorChar;
        
        /// <summary>
        /// Gets user home directory.
        /// </summary>
        public static readonly string UserHomeDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
    }
}