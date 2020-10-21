using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
        public List<Teams> ListTeams()
        {
            using (var db = new SupenEntities())
            {
                var listTeams = db.Teams.ToList();
                return listTeams;
            }
        }
        public Teams GetTeam(Guid id)
        {
            using (var db = new SupenEntities())
            {
                var getTeam = db.Teams.Where(t => t.TeamId == id).FirstOrDefault();
                return getTeam;
            }
        }
    }
}