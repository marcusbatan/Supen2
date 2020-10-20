using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Database
{
    public class TeamRepos
    {
        public Team CreateTeam(string teamName)
        {
            using (var db = new SupenEntities())
            {
                var team = new Team
                {
                    TeamName = teamName
                };
                db.Team.Add(team);
                db.SaveChanges();
                return team;
            }
        }
    }
}