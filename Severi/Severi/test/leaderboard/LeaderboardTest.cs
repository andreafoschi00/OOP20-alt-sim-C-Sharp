using System.Collections.Generic;
using System.Linq;
using Severi.user;
using Xunit;

namespace Severi.test.leaderboard
{
    public class LeaderboardTest
    {
        private readonly Dictionary<string, int> _users = new();

        private const int TopFive = 5;
        private readonly IUser _user1 = new User("luca", 100);
        private readonly IUser _user2 = new User("paolo", 200);
        private readonly IUser _user3 = new User("giacomo", 300);
        private readonly IUser _user4 = new User("gianni", 400);
        private readonly IUser _user5 = new User("gigi", 500);

        public LeaderboardTest()
        {
            var users = new List<IUser> { _user1, _user2, _user3, _user4, _user5 };
            foreach (var user in users)
            {
                _users.Add(user.Name, user.Score);
            }
        }

        [Fact]
        public void TestLeaderboard()
        {
            var topFive = TopFiveUsers();
            Assert.Equal(_users.Keys.ElementAt(4), topFive.Keys.ElementAt(0));
        }

        private Dictionary<string, int> TopFiveUsers()
        {
            return _users.OrderByDescending(u => u.Value)
                .Take(TopFive)
                .ToDictionary(u => u.Key, u => u.Value);
        }
    }
}
