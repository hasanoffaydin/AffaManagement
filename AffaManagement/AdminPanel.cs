using AffaManagement.DataBase;
using AffaManagement.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace AffaManagement
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();

        }


        private void LoadTeams()
        {
            using (var context = new DbHelper())
            {
                var teams = context.Teams.ToList();

                comboBox1.DataSource = new BindingList<Team>(teams);
                comboBox1.DisplayMember = "TeamName";
                comboBox1.ValueMember = "Id";

                comboBox2.DataSource = new BindingList<Team>(teams);
                comboBox2.DisplayMember = "TeamName";
                comboBox2.ValueMember = "Id";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DbHelper())
                {

                    var team = new Team
                    {
                        TeamName = teamName.Text,
                        TeamScore = 0
                    };

                    context.Teams.Add(team);
                    context.SaveChanges();

                    LoadTeams();
                    MessageBox.Show("Yeni Komanda Elave Olundu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xəta baş verdi: {ex.Message}");
            }
        }

        private void AdminPanel_Load_1(object sender, EventArgs e)
        {
            LoadTeams();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DbHelper())
                {
                    int homeTeamId = (int)comboBox1.SelectedValue;
                    int awayTeamId = (int)comboBox2.SelectedValue;
                    DateTime gameDate = dateTimePicker1.Value;

                    var game = new Game
                    {
                        HomeTeamId = homeTeamId,
                        AwayTeamId = awayTeamId,
                        GameDate = gameDate
                    };

                    context.Games.Add(game);
                    context.SaveChanges();

                    MessageBox.Show("Yeni Oyun Elave Olundu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xəta baş verdi: {ex.Message}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Oyun_Neticeleri oyun_Neticeleri = new Oyun_Neticeleri();
            oyun_Neticeleri.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TurnirCedveli turnirCedveli = new TurnirCedveli();  
            turnirCedveli.Show();   
            this.Hide();
        }
    }
}
