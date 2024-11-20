using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffaManagement.Entity
{
    internal class ResultGame
    {
        public int Id { get; set; } 
        public int GameId { get; set; }
        public string HomeTeamName { get; set; }
        public string AwayTeamName { get; set; }
        public int HomeTeamGoals { get; set; }
        public int AwayTeamGoals { get;set; }
        public DateTime GameTime { get; set; }
    }
}
