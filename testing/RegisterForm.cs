using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace testing
{
    public partial class RegisterForm : MaterialForm
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {   
            if (registerLogin.Text==string.Empty)
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (registerPassword.Text == string.Empty)
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            if (registerLocalPort.Text == string.Empty)
            {
                MessageBox.Show("Введите ваш порт");
                return;
            }

            if (registerRemoteAdress.Text == string.Empty)
            {
                MessageBox.Show("Введите адрес собеседника");
                return;
            }

            if (registerRemotePort.Text == string.Empty)
            {
                MessageBox.Show("Введите порт собеседника");
                return;
            }

            if (registerName.Text == string.Empty)
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (IsUserExists())
                return;


            DataBase dataBase = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`Login`, `Password`, `localPort`, `remoteAdress`, `remotePort`, `Name`) VALUES (@login, @password, @localport, @remoteadress, @remoteport, @name)",dataBase.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = registerLogin.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = registerPassword.Text;
            command.Parameters.Add("@localport", MySqlDbType.Int32).Value = registerLocalPort.Text;
            command.Parameters.Add("@remoteadress", MySqlDbType.VarChar).Value = registerRemoteAdress.Text;
            command.Parameters.Add("@remoteport", MySqlDbType.Int32).Value = registerRemotePort.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = registerName.Text;

            dataBase.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Вы зарегистрировались");
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

            }
            else
                MessageBox.Show("Аккаунт не создан");
            dataBase.CloseConnection();

        }

        private void enterLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        public Boolean IsUserExists()
        {
            DataBase dataBase = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @uL", dataBase.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = registerLogin.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже есть");
                return true;

            }
            else
            {
                return false;
            }
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
