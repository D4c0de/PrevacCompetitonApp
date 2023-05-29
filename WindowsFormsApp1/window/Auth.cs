using prevacCompetition_desktopAppWinForms;
using prop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Auth : Form
    {
        public Connections_prop prop { get; set; }
        public Auth()
        {
            InitializeComponent();
            settingsPanel.Visible = false;
            loginPanel.BringToFront();
            prop = new Connections_prop();
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            loginPanel.Visible = false;
            settingsPanel.Visible = true;
            settingsPanel.BringToFront();
            ConnectionSettingsPanel();
        }
        private void ConnectionSettingsPanel()
        {
            IpConn.Text = prop.adres;
            PortConn.Text = prop.adres;
            serial.Text = prop.adres;
            if (!prop.preferRTU)
            {
                useTCP.BringToFront();
                option.Text = "TCP";
            }
            else
            {
                useRTU.BringToFront();
                option.Text = "RTU";
            }
        }
    
        private void Accept_Click(object sender, EventArgs e)
        {
            SaveSettings();
            loginPanel.BringToFront();
            loginPanel.Visible = true;
            settingsPanel.Visible = false;
        }

        private void SaveSettings()
        {
            if (option.Text == "RTU")
            {

                prop = new Connections_prop(serial.Text);
            }
            else
            {
                prop = new Connections_prop(IpConn.Text, int.Parse(PortConn.Text));
            }
        }
        private void Option_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (option.Text == "RTU")
            {
                useRTU.BringToFront();
            }
            else
            {
                useTCP.BringToFront();
            }

        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            prop = Connections_prop.SetDeafult(prop); 
            try
            {
                connection.Connect(prop);
                await Login(login.Text, password.Text);
                Close();
            }
            catch (Exception ex)
            {
                if (ex == new Exception("Login"))
                {
                    MessageBox.Show("Problem witch login");
                }
                else
                {
                    MessageBox.Show("Connect Problem");
                }
                connection.DissConnect();
            }
            
        }

        private async Task Login(string login, string password)
        {
            connection.Write_Auth(StringOperation.StringToValue(login), GetHashSha256(password));
            while (connection.reg_read_first()!=11)
            {
                await Task.Delay(100);
            }
            int t= connection.reg_read_single(1);
            if (t==0)
            {
                throw new Exception("login");
            }
            Program.tier = connection.reg_read_single(1);
            connection.GetToken();
        }
        public static int[] GetHashSha256(string text)
        {
            
            byte[] bytes = Encoding.Unicode.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            
            return StringOperation.BytesToInt(hash);
        }
    }
}
