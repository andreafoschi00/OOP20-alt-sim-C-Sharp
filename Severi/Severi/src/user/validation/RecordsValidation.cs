using Severi.user.records;

namespace Severi.user.validation
{
    public class RecordsValidation
    {
        /// <summary>
        /// Validates that directory containing file exists.
        /// </summary>
        private void UserRecordsDirValidation()
        {
            ValidateDir();
        }

        /// <summary>
        /// Validates hidden directory existence.
        /// </summary>
        private void ValidateDir()
        {
            CheckDirExistence();
            FileOperations.CreateDirectory(RecordsFolder.UserRecordsDirectoryPath);
        }

        /// <summary>
        /// Checks if directory exists.
        /// </summary>
        private void CheckDirExistence()
        {
            FileOperations.CreateDirectory(RecordsFolder.RecordsDirectoryPath);
        }

        private void ValidateFile()
        {
            UserRecordsDirValidation();
            FileOperations.CreateFile(RecordsFolder.UserRecordsFilePath);
        }

        /// <summary>
        /// Validates users file existence.
        /// </summary>
        public void UserRecordsFileValidation()
        {
            ValidateFile();
        }
    }
}
