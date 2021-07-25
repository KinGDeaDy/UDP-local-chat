using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace testing
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            materialLabel1.BackColor = Color.FromArgb(51, 51, 51);
            materialLabel1.ForeColor = Color.White;
            materialLabel2.BackColor = Color.FromArgb(51, 51, 51);
            materialLabel2.ForeColor = Color.White;
            wrongDataLabel.Visible = false;
            wrongDataLabel.ForeColor = Color.FromArgb(198, 26, 26);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string loginUser = loginFilled.Text;
            string passwordUser = passwordFilled.Text;

            DataBase dataBase = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @uL AND `Password` = @uP",dataBase.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordUser;

            adapter.SelectCommand = command;
          
                adapter.Fill(table);


            if (table.Rows.Count > 0)
            {

                MessageBox.Show("Вход выполнен");

                this.Hide();
                ChatForm chatForm = new ChatForm(loginFilled.Text);
                chatForm.Show();
                

            }
            else
                wrongDataLabel.Visible = true;
                
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
