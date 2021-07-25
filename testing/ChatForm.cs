using System;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Net;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace testing
{
    public partial class ChatForm : MaterialForm
    {
        string remoteAdress;
        Thread reciveThread;
        int remoteport;
        int localPort;
        string username;
        public ChatForm(string login)
        {
            
            InitializeComponent();
            materialLabel3.Text = login;
            DataBase dataBase = new DataBase();

            dataBase.OpenConnection();


            var command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @uL", dataBase.GetConnection());

            command.Parameters.AddWithValue("@uL", login);
            

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read()) // reader.Read() возвращает true и переходит к следующему ряду.
                {
                    username = reader.GetString("Name");
                    localPort = reader.GetInt32("localPort");
                    remoteport = reader.GetInt32("remotePort");
                    remoteAdress = reader.GetString("remoteAdress");
                    chatBox.Text = reader.GetString("Messages");
                }
            }
            dataBase.CloseConnection();

            sendMessageButton.Enabled = true;
            messageChatBox.ReadOnly = false;
            chatBox.ReadOnly = true;
            var time = DateTime.Now.ToShortDateString()+" "+ DateTime.Now.ToShortTimeString();
            chatBox.Text += "\r\n";
            chatBox.AppendText($"{time}: Вы вошли в чат");
        }
        private void SendFirstMessage()
        {
            UdpClient sender = new UdpClient();
            try
            {
                string message = username + " вошел в чат";
                var data = Encoding.UTF8.GetBytes(message);
                sender.Send(data, data.Length, remoteAdress, remoteport);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ReceiveMessage()
        {
            UdpClient receiver = new UdpClient(localPort);
            IPEndPoint remoteIp = null;
            try
            {
                while (true)
                {
                    var data = receiver.Receive(ref remoteIp);
                    var message = Encoding.UTF8.GetString(data);
                    this.Invoke(new MethodInvoker(() =>
                    {
                        var time = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
                        chatBox.AppendText("\r\n" + time + ": " + message);
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            private void SendMessage()
            {
                UdpClient sender = new UdpClient();
                try
                {   
                        string message = username + ": " + messageChatBox.Text;
                        var data = Encoding.UTF8.GetBytes(message);
                        var time = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
                        chatBox.AppendText("\r\n" + time + ": " + message);
                        sender.Send(data, data.Length, remoteAdress, remoteport);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            SendMessage();
            messageChatBox.Clear();
        }
    
            private void Form1_FormClosing(object sender, FormClosingEventArgs e)
            {
                DataBase dataBase = new DataBase();

                MySqlCommand command = new MySqlCommand("UPDATE `users` SET Messages = @messages WHERE Login = @uL", dataBase.GetConnection());
                command.Parameters.Add("@messages", MySqlDbType.VarChar).Value = chatBox.Text;
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = materialLabel3.Text;
                dataBase.OpenConnection();
                command.ExecuteNonQuery();
                dataBase.CloseConnection();
                Application.Exit();
      
            }

            private void messageChatBox_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter && sendMessageButton.Enabled==true)
                {
                    SendMessage();
                    messageChatBox.Clear();
                }

            }


            private void ChatForm_Load(object sender, EventArgs e)
            {
                MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
                skinManager.AddFormToManage(this);
                skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
                skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
                chatBox.BackColor = Color.FromArgb(51, 51, 51);
                messageChatBox.BackColor = Color.FromArgb(51, 51, 51);
                messageChatBox.ForeColor = Color.White;
                try
                {
                    Thread reciveThread = new Thread(new ThreadStart(ReceiveMessage));
                    reciveThread.IsBackground = true;
                    reciveThread.Start();
                    SendFirstMessage();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
