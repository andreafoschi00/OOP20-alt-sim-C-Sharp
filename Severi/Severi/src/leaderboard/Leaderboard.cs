using System;
using System.Collections.Generic;
using System.Linq;
using Severi.user.records;

namespace Severi.leaderboard
{
    public static class Leaderboard
    {
        private static readonly Dictionary<string, int> Users = FileOperations.Users;
        private const int TopFive = 5;

        /// <summary>
        /// Gets top five users by points obtained.
        /// </summary>
        /// <returns>top five users with their score</returns>
        private static Dictionary<string, int> TopFiveUsers()
        {
            return Users.OrderByDescending(u => u.Value)
                .Take(TopFive)
                .ToDictionary(u => u.Key, u => u.Value);
        }

        /// <summary>
        /// Prints top five users.
        /// </summary>
        public static void PrintLeaderboard()
        {
            TopFiveUsers().Select(i => $"- {i.Key}: {i.Value}").ToList().ForEach(Console.WriteLine);
        }
        
    }
}
