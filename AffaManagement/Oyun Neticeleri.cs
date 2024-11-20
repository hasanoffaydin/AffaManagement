using AffaManagement.DataBase;
using AffaManagement.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AffaManagement
{
    public partial class Oyun_Neticeleri : Form
    {
        public Oyun_Neticeleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }

        private void neticeElaveEt_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null || (int)comboBox1.SelectedValue == -1)
            {
                MessageBox.Show("Zəhmət olmasa bir oyun seçin.");
                return;
            }

            using (var context = new DbHelper())
            {
                int selectedGameId = (int)comboBox1.SelectedValue;
                var selectedGame = context.Games.FirstOrDefault(g => g.GameId == selectedGameId);

                if (selectedGame != null)
                {
                    var resultGame = new ResultGame
                    {
                        GameId = selectedGame.GameId,
                        HomeTeamName = textBox1.Text,
                        AwayTeamName = textBox2.Text,
                        HomeTeamGoals = Convert.ToInt32(komanda1Score.Text),
                        AwayTeamGoals = Convert.ToInt32(komanda2Score.Text),
                        GameTime = selectedGame.GameDate
                    };

                    context.ResultGames.Add(resultGame);
                    context.SaveChanges();

                    int homeTeamGoals = resultGame.HomeTeamGoals;
                    int awayTeamGoals = resultGame.AwayTeamGoals;

                    var homeTeam = context.Teams.FirstOrDefault(t => t.TeamName == resultGame.HomeTeamName);
                    var awayTeam = context.Teams.FirstOrDefault(t => t.TeamName == resultGame.AwayTeamName);

                    if (homeTeam != null && awayTeam != null)
                    {
                        if (homeTeamGoals > awayTeamGoals)
                        {
                            homeTeam.TeamScore += 3;
                        }
                        else if (homeTeamGoals < awayTeamGoals) 
                        {
                            awayTeam.TeamScore += 3;
                        }
                        else 
                        {
                            homeTeam.TeamScore += 1;
                            awayTeam.TeamScore += 1;
                        }

                        
                        context.SaveChanges();
                    }

                   
                    Oyun_Neticeleri_Load(sender, e);

                    MessageBox.Show("Nəticə əlavə edildi!");
                }
                else
                {
                    MessageBox.Show("Seçilmiş oyun tapılmadı.");
                }
            }
        }

        private void Oyun_Neticeleri_Load(object sender, EventArgs e)
        {
            using (var context = new DbHelper())
            {
              
                var games = context.Games.ToList();
                var resultGameIds = context.ResultGames.Select(rg => rg.GameId).ToList();

                
                var teamNames = games
                                .Where(g => !resultGameIds.Contains(g.GameId))
                                .Select(g => new Team
                                {
                                    Id = g.GameId,
                                    TeamName = context.Teams
                                                         .Where(t => t.Id == g.HomeTeamId)
                                                         .Select(t => t.TeamName)
                                                         .FirstOrDefault() + " vs " +
                                             context.Teams
                                                         .Where(t => t.Id == g.AwayTeamId)
                                                         .Select(t => t.TeamName)
                                                         .FirstOrDefault()
                                }).ToList();

                

                
                comboBox1.DataSource = new BindingList<Team>(teamNames);
                comboBox1.DisplayMember = "TeamName";
                comboBox1.ValueMember = "Id";

               
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null || !(comboBox1.SelectedValue is int selectedGameId) || selectedGameId == -1)
            {
                return; 
            }

            using (var context = new DbHelper())
            {
                var selectedGame = context.Games.FirstOrDefault(g => g.GameId == selectedGameId);

                if (selectedGame != null)
                {
                    var homeTeam = context.Teams.FirstOrDefault(t => t.Id == selectedGame.HomeTeamId);
                    var awayTeam = context.Teams.FirstOrDefault(t => t.Id == selectedGame.AwayTeamId);

                    
                    textBox1.Text = homeTeam?.TeamName ?? "Ev komandası tapılmadı";
                    textBox2.Text = awayTeam?.TeamName ?? "Qonaq komandası tapılmadı";
                }
            }
        }


    }
}
