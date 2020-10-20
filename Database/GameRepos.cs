using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class GameRepos
    {
        public Game addGames(int id, string hometeam, string awayteam, int homescore, int awayscore, int teamId)
        {
            using (var db = new SupenEntities())
            {
                var addGame = new Game
                {
                    GameId = id,
                    HomeTeam = hometeam,
                    AwayTeam = awayteam,
                    HomeScore = homescore,
                    AwayScore = awayscore,
                };
                db.Game.Add(addGame);
                db.SaveChanges();
                return addGame;
            }
        }
    }
}
