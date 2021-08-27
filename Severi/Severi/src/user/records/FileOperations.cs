using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Severi.user.validation;

namespace Severi.user.records
{
    public class FileOperations
    {
        
        public static Dictionary<string, int> Users { get; private set; } = new ();
        
        /// <summary>
        /// Creates directory by given path.
        /// </summary>
        /// <param name="path">to directory</param>
        public static void CreateDirectory(in string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        /// <summary>
        /// Creates file by path.
        /// </summary>
        /// <param name="path">to file</param>
        public static void CreateFile(in string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }
        }

        /// <summary>
        /// Loads file by path.
        /// </summary>
        /// <param name="file">to load</param>
        protected static void LoadFile(in string file)
        {
            new RecordsValidation().UserRecordsFileValidation();
            var jsonString = File.ReadAllText(file);
            Users = JsonSerializer.Deserialize<Dictionary<string, int>>(jsonString) ?? new Dictionary<string, int>();
        }
        
        /// <summary>
        /// Updates file by path.
        /// </summary>
        /// <param name="file">to update</param>
        protected static void UpdateFile(in string file)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var jsonString = JsonSerializer.Serialize(Users, options);
            new RecordsValidation().UserRecordsFileValidation();
            File.WriteAllText(file, jsonString);
        }

        /// <summary>
        /// Add user to file.
        /// </summary>
        /// <param name="user">to add</param>
        public virtual void AddUser(in IUser user)
        {
            LoadFile(RecordsFolder.UserRecordsFilePath);
            if (!Users.ContainsKey(user.Name.Trim()))
            {
                Users.Add(user.Name.Trim(), user.Score);
            }
            UpdateFile(RecordsFolder.UserRecordsFilePath);
        }

        /// <summary>
        /// Checks if given name is already taken.
        /// </summary>
        /// <param name="name">to check</param>
        /// <returns>true if taken</returns>
        public virtual bool IsTaken(in string name)
        {
            LoadFile(RecordsFolder.UserRecordsFilePath);
            return Users.ContainsKey(name);
        }

        /// <summary>
        /// Clears user records file content.
        /// </summary>
		public virtual void ClearRecordsFile()
		{
			Users.Clear();
            UpdateFile(RecordsFolder.UserRecordsFilePath);
		}
    }
}
