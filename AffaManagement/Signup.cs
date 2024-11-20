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

namespace AffaManagement
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DbHelper())
                {
                    var user = new User
                    {
                        Name = name.Text,
                        Email = email.Text,
                        Password = password.Text,
                    };

                    context.Users.Add(user);
                    context.SaveChanges();
                    MessageBox.Show("Yeni User Elave Olundu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xəta baş verdi: {ex.Message}");
            }
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
        }
    }
}
