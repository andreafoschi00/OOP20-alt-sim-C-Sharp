using Severi.common;

namespace Severi.user.records
{
    public static class RecordsFolder
    {
        /// <summary>
        /// Path to hidden directory.
        /// </summary>
        public static readonly string RecordsDirectoryPath =
            OsDependent.UserHomeDirectory + OsDependent.Separator + ".altsim-c#";

        /// <summary>
        /// Path to directory containing users file.
        /// </summary>
        public static readonly string UserRecordsDirectoryPath =
            RecordsDirectoryPath + OsDependent.Separator + "user_records";

        /// <summary>
        /// Path to users file.
        /// </summary>
        public static readonly string UserRecordsFilePath =
            UserRecordsDirectoryPath + OsDependent.Separator + "users.json";
    }
}
