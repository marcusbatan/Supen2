using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class GameRepos
    {
        public Games addGames(string hometeam, string awayteam, int? homescore, int? awayscore)
        {
            using (var db = new SupenEntities())
            {
                var addGame = new Games
                {
                    GameId = Guid.NewGuid(),
                    HomeTeam = hometeam,
                    AwayTeam = awayteam,
                    HomeScore = homescore,
                    AwayScore = awayscore,
                };
                db.Games.Add(addGame);
                db.SaveChanges();
                return addGame;
            }
        }
    }
}
