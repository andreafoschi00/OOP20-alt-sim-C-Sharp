using System;
using System.IO;
using Severi.test.validation;
using Severi.user;
using Severi.user.builder;
using Severi.user.records;
using Xunit;

namespace Severi.test.records
{
    public class UserRecordsTest
    {
        private readonly FileOperationsTest _fileOperations = new();
        private readonly IUser _user = UserBuilder.BuildUser("Andrea", 500);

        [Fact]
        public void TestFile()
        {
            _fileOperations.CopyRecordsFile();
            Assert.True(File.Exists(RecordsFolder.UserRecordsFilePath));
            _fileOperations.ClearRecordsFile();
            _fileOperations.AddUser(_user);

            if (IsInFile(_user.Name))
            {
                _fileOperations.RemoveFileCopy();
                Assert.False(File.Exists(RecordsFolder.UserRecordsFilePath));
            }
        }

        /// <summary>
        /// Checks if user name is in file.
        /// </summary>
        /// <param name="name">to check</param>
        /// <returns>true if name is in file</returns>
        private static bool IsInFile(in string name)
        {
            var content = File.ReadAllText(RecordsFolder.UserRecordsFilePath);
            return content.Contains(name);
        }
    }
}
