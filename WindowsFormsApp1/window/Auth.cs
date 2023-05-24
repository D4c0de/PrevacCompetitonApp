using prevacCompetition_desktopAppWinForms;
using prop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Auth : Form
    {
        public Connections_prop prop { get; set; }
        public Auth(string token)
        {
            InitializeComponent();
            settingsPanel.Visible = false;
            loginPanel.BringToFront();
            prop = new Connections_prop();
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            
        }

        private void connect_Click(object sender, EventArgs e)
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
    
        private void accept_Click(object sender, EventArgs e)
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
        private void option_SelectedIndexChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            prop= Connections_prop.SetDeafult(prop); 
            try
            {
                connection.Connect(prop);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connect Problem");
                connection.DissConnect();
            }
            
        }
    }
}
