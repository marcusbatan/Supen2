using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Database
{
    public class TeamRepos
    {
        public Teams CreateTeam(string teamName)
        {
            using (var db = new SupenEntities())
            {
                var team = new Teams
                {
                    TeamId = Guid.NewGuid(),
                    TeamName = teamName
                };
                db.Teams.Add(team);
                db.SaveChanges();
                return team;
            }
        }
    }
}