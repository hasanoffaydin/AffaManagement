using AffaManagement.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AffaManagement.Business
{
    internal class TurnirAndResult
    {
        public Object TurnirCedveli()
        {
            using (var context = new DbHelper())
            {
                var teams = context.Teams.ToList();

                var standings = new List<dynamic>();

                foreach (var team in teams)
                {
                    var totalGames = context.Games.Count(g => g.HomeTeamId == team.Id || g.AwayTeamId == team.Id);

                    var wins = context.ResultGames.Count(rg =>
                        (rg.HomeTeamName == team.TeamName && rg.HomeTeamGoals > rg.AwayTeamGoals) ||
                        (rg.AwayTeamName == team.TeamName && rg.AwayTeamGoals > rg.HomeTeamGoals));

                    var losses = context.ResultGames.Count(rg =>
                        (rg.HomeTeamName == team.TeamName && rg.HomeTeamGoals < rg.AwayTeamGoals) ||
                        (rg.AwayTeamName == team.TeamName && rg.AwayTeamGoals < rg.HomeTeamGoals));

                    var draws = context.ResultGames.Count(rg =>
                        rg.HomeTeamGoals == rg.AwayTeamGoals &&
                        (rg.HomeTeamName == team.TeamName || rg.AwayTeamName == team.TeamName));

                    var goalsScored = context.ResultGames.Where(rg =>
                        rg.HomeTeamName == team.TeamName || rg.AwayTeamName == team.TeamName)
                        .Sum(rg => rg.HomeTeamName == team.TeamName ? rg.HomeTeamGoals : rg.AwayTeamGoals);

                    var goalsConceded = context.ResultGames.Where(rg =>
                        rg.HomeTeamName == team.TeamName || rg.AwayTeamName == team.TeamName)
                        .Sum(rg => rg.HomeTeamName == team.TeamName ? rg.AwayTeamGoals : rg.HomeTeamGoals);

                    var points = context.ResultGames.Sum(rg =>
                        (rg.HomeTeamName == team.TeamName && rg.HomeTeamGoals > rg.AwayTeamGoals) ||
                        (rg.AwayTeamName == team.TeamName && rg.AwayTeamGoals > rg.HomeTeamGoals) ? 3 :
                        rg.HomeTeamGoals == rg.AwayTeamGoals &&
                        (rg.HomeTeamName == team.TeamName || rg.AwayTeamName == team.TeamName) ? 1 : 0);

                    standings.Add(new
                    {
                        TeamName = team.TeamName,
                        TotalGames = totalGames,
                        Wins = wins,
                        Losses = losses,
                        Draws = draws,
                        GoalsScored = goalsScored,
                        GoalsConceded = goalsConceded,
                        Points = points
                    });
                }

                var sortedStandings = standings
                    .OrderByDescending(x => x.Points)
                    .ThenByDescending(x => x.GoalsScored)
                .ToList();

                
                return sortedStandings;

            }
        }
        public Object ResultCedveli()
        {
            using(var context = new DbHelper())
            {
                var resultGames = context.ResultGames
                        .Select(rg => new
                        {

                            rg.HomeTeamName,
                            rg.AwayTeamName,
                            rg.HomeTeamGoals,
                            rg.AwayTeamGoals,
                            rg.GameTime
                        })
                .ToList();

                return resultGames;
            }
        }
    }
}
