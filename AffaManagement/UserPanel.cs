using AffaManagement.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AffaManagement
{
    public partial class UserPanel : Form
    {
        public UserPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            TurnirAndResult turnirAndResult = new TurnirAndResult();    
            dataGridView1.DataSource = turnirAndResult.TurnirCedveli();
            dataGridView2.DataSource = turnirAndResult.ResultCedveli();
        }
    }
}
