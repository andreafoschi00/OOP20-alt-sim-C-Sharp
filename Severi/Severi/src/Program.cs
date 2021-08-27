using System;
using System.Threading;
using Severi.leaderboard;
using Severi.user.builder;
using Severi.user.records;
using Severi.user.score;
using Severi.user.validation;

namespace Severi
{
    public static class Program
    {
        private static void Main()
        {
            new RecordsValidation().UserRecordsFileValidation();
            var nameQuality = new NameQuality();
            var fileOperations = new FileOperations();

            while (true)
            {
                Console.WriteLine("NAME SHOULD BE 1-12 CHARS MAX AND MUST CONTAIN ONLY NUMBERS AND LETTERS");
                Console.Write("Enter a name: ");
                var name = Console.ReadLine();

                if (nameQuality.CheckName(name).Equals(NameResult.Taken))
                {
                    Console.WriteLine("Name is already taken!");
                    continue;
                } 
                if (!nameQuality.CheckName(name).Equals(NameResult.Correct)) continue;
                
                Console.WriteLine("Name passes regex checks!\n");
                Console.WriteLine("Building user by entered name...");
                Console.WriteLine("Generating random score to assign to user...");
                var score = Score.GenerateRandomScore();
                fileOperations.AddUser(UserBuilder.BuildUser(name, score));
                Thread.Sleep(1500);
                Console.WriteLine("User built!\n");
                Console.WriteLine("LEADERBOARD:");
                Leaderboard.PrintLeaderboard();
                
                break;
            }
        }
    }
}
