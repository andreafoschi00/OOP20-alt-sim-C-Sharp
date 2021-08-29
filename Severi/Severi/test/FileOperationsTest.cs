using System;
using System.IO;
using Severi.user;
using Severi.user.records;

namespace Severi.test
{
    public class FileOperationsTest : FileOperations
    {
        public override void ClearRecordsFile()
        {
            LoadFile(RecordsFolder.UserRecordsFilePath + ".copy");
            Users.Clear();
            UpdateFile(RecordsFolder.UserRecordsFilePath + ".copy");
        }

        public void CopyRecordsFile()
        {
            if (!File.Exists(RecordsFolder.UserRecordsFilePath + ".copy"))
            {
                File.Copy(RecordsFolder.UserRecordsFilePath, RecordsFolder.UserRecordsFilePath + ".copy");
            }
        }

        public void RemoveFileCopy()
        {
            if (File.Exists(RecordsFolder.UserRecordsFilePath + ".copy"))
            {
                File.Delete(RecordsFolder.UserRecordsFilePath + ".copy");
            }
        }

        public override void AddUser(in IUser user)
        {
            LoadFile(RecordsFolder.UserRecordsFilePath + ".copy");
            if (!Users.ContainsKey(user.Name.Trim()))
            {
                Users.Add(user.Name.Trim(), user.Score);
            }

            UpdateFile(RecordsFolder.UserRecordsFilePath + ".copy");
        }

        public override bool IsTaken(in string name)
        {
            LoadFile(RecordsFolder.UserRecordsFilePath + ".copy");
            return Users.ContainsKey(name);
        }
    }
}
