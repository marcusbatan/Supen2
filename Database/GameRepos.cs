using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class GameRepos
    {
        public Games addGames(int id, string hometeam, string awayteam, int homescore, int awayscore, int teamId)
        {
            using (var db = new SupenEntities())
            {
                var addGame = new Games
                {
                    Id = id,
                    HomeTeam = hometeam,
                    AwayTeam = awayteam,
                    HomeScore = homescore,
                    AwayScore = awayscore,
                    TeamId = teamId
                };
                db.Games.Add(addGame);
                db.SaveChanges();
                return addGame;
            }
        }
    }
}
