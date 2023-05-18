using prevacCompetition_desktopAppWinForms;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void run_Click(object sender, EventArgs e)
        {
            connection.isRunning = true;
            if (connection.isConnected)
            {
                progressBar1.Value = 0;
                int name = typeOfKronzkas.SelectedIndex;
                int quantity;

                if (!Int32.TryParse(this.quantity.Text, out quantity))
                {
                    MessageBox.Show("Invalid quantity. Please enter a valid number.");
                    return;
                }

                int[] i = { 1, name, quantity };
                connection.reg_write_multiply(0, i);

                await progress();
            }
            else
            {
                MessageBox.Show("Connection not established. Please connect first.");
            }
            connection.isRunning = false;
        }

        private async Task progress()
        {
            mainLabel.Text = "Data Sent";
            await Task.Delay(100);
            while (connection.reg_read_first() != 11)
            {
                await Task.Delay(100);
            }
            mainLabel.Text = "Pieces going into Furnace";
            await Task.Delay(100);
            while (connection.reg_read_first() != 12)
            {
                await Task.Delay(100);
            }
            int loading = connection.reg_read_single(1);
            if (loading == 404)
            {
                MessageBox.Show("Something's gone wrong");
                progressBar1.Value = 0;
                return;
            }
            mainLabel.Text = "Heating";
            await Task.Delay(100);
            while (loading < 98)
            {
                await Task.Delay(100);
                if (progressBar1.Value != loading)
                {
                    progressBar1.Value = loading;
                }
                loading = connection.reg_read_single(1);
            }
            mainLabel.Text = "Afterburn";
            await Task.Delay(100);
            while (loading != 100)
            {
                await Task.Delay(100);
                loading = connection.reg_read_single(1);
            }
            mainLabel.Text = "Pieces going under Press";
            await Task.Delay(100);
            while (connection.reg_read_first() != 13)
            {
                await Task.Delay(100);
            }
            mainLabel.Text = "Pieces going into furnace";
            await Task.Delay(100);
            while (connection.reg_read_first() != 14)
            {
                await Task.Delay(100);
            }
            mainLabel.Text = "Pieces going into sorter";
            await Task.Delay(100);
            while (connection.reg_read_first() != 15)
            {
                await Task.Delay(100);
            }
            mainLabel.Text = "";
            connection.reg_clr(0);
            progressBar1.Value = 100;
            MessageBox.Show("Success");
            return;
        }

        private void connect_Click(object sender, EventArgs e)
        {
            connection.isRunning = true;
            if (!connection.isConnected)
            {
                connectb.Text = "Connecting ...";
                connectb.ForeColor = Color.Blue;
                quantity.ReadOnly = true;
                connect();
                if (connection.isConnected)
                {
                    quantity.ReadOnly = false;
                    connectb.Text = "Connected";
                    connectb.ForeColor = Color.Green;
                    quantity.ReadOnly = false;
                    getFromRaspberryPi();
                }
                else
                {
                    connectb.Text = "Not Connected";
                    connectb.ForeColor = Color.Red;
                }
            }
            connection.isRunning = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (connection.isConnected)
            {
                Form2 f2 = new Form2(typeOfKronzkas.Items);
                f2.Show();
            }
            else
            {
                MessageBox.Show("Connect first");
            }
        }

        private async void getFromRaspberryPi()
        {
            connection.reg_write_first(3);
            int wait;
            while ((wait = connection.reg_read_single(1)) == 0)
            {
            }

            if (wait == 9999)
            {
                return;
            }

            for (int i = 0; i < wait; i++)
            {
                StringBuilder stringBuilder = new StringBuilder();
                int[] add = connection.reg_read_multiply((i + 1) * 10, 10);

                for (int j = 0; j < add.Length; j++)
                {
                    int low = add[j] % 255;
                    int high = (add[j] - low) / 255;
                    stringBuilder.Append((char)low);
                    stringBuilder.Append((char)high);
                }

                var outp = stringBuilder.ToString();
                typeOfKronzkas.Items.Add(outp);
                connection.reg_clr(i);
            }

            connection.reg_clr(0);
            return;
        }

        private void typeOfKronzkas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.DissConnect();
        }

        private void IpConn_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}