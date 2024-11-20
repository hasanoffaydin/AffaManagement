using AffaManagement.DataBase;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AffaManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new DbHelper())
            {
                string email = username.Text;
                string password = parol.Text;

                var user = context.Users
                    .FirstOrDefault(u => u.Email == email && u.Password == password);

                if (user != null)
                {

                    MessageBox.Show("Giriş uğurludur!");


                    if (user.Email == "admin" && user.Password == "admin")
                    {

                        AdminPanel adminPanel = new AdminPanel();
                        adminPanel.Show();
                    }
                    else
                    {

                        UserPanel userPanel = new UserPanel();
                        userPanel.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Yanlış istifadəçi adı və ya şifrə.");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            parol.PasswordChar = '*';
        }
    }
}
