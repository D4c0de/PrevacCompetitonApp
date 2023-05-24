using prevacCompetition_desktopAppWinForms;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Linq;
using System.Diagnostics.Eventing.Reader;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Form2 f2;
        List<Piece> Pieces = new List<Piece>();
        public Form1()
        {
            InitializeComponent();
            
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            await getFromRaspberryPi();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            f2 = new Form2(typeOfKronzkas.Items, Pieces);
            f2.Show();
        }

        private async Task getFromRaspberryPi()
        {
            connection.reg_write_first(3);
            int wait;
            while ((wait = connection.reg_read_single(1)) == 0)
            {
                await Task.Delay(500);
            }

            if (wait == 9999)
            {
                return;
            }

            for (int i = 0; i < wait; i++)
            {
                StringBuilder stringBuilder = new StringBuilder();
                int[] add = connection.reg_read_multiply((i + 1) * 10, 10);
                int id = add[0];

                for (int j = 1; j < add.Length; j++)
                {
                    int low = add[j] % 255;
                    int high = (add[j] - low) / 255;
                    stringBuilder.Append((char)low);
                    stringBuilder.Append((char)high);
                }

                string outp = stringBuilder.ToString();
                Pieces.Add(new Piece(outp, id));
                typeOfKronzkas.Items.Add(outp);
                connection.reg_clr(i);
            }

            connection.reg_clr(0);
            return;
        }
        private async void run_Click(object sender, EventArgs e)
        {
            await connection.WaitUntilRedy();

            connection.isRunning = true;
            if (!connection.isConnected)
            {
                MessageBox.Show("Connection not established. Please connect first.");
                connection.isRunning = false;
                return;
            }
            progressBar1.Value = 0;

            int index = typeOfKronzkas.SelectedIndex;
            int ID = Pieces[index].ID;
            int quantity;

            if (!Int32.TryParse(this.quantity.Text, out quantity))
            {
                MessageBox.Show("Invalid quantity. Please enter a valid number.");
                connection.isRunning = true;
                return;
            }
            int[] send = { 1, ID, quantity };
            connection.reg_write_multiply(0, send);

            await progress();
            connection.isRunning = false;
        }
        private async Task progress()
        {
            mainLabel.Text = "Data Sent";
            while (true)
            {
                if (connection.reg_read_first() == 11)
                {
                    await Task.Delay(100);
                    mainLabel.Text = "Pieces going into Furnace";
                }
                else if (connection.reg_read_first() == 12)
                {
                    mainLabel.Text = "Heating";
                    int loading = connection.reg_read_single(1);

                    if (loading == 404)
                    {
                        MessageBox.Show("Something's gone wrong");
                        progressBar1.Value = 0;
                        return;
                    }
                    await Task.Delay(100);
                    while (connection.reg_read_first() == 12)
                    {
                        await Task.Delay(100);
                        if (progressBar1.Value != loading)
                        {
                            progressBar1.Value = loading;
                        }
                        loading = connection.reg_read_single(1);
                        await Task.Delay(100);
                    }
                    mainLabel.Text = "Afterburn";
                    await Task.Delay(100);
                }
                else if (connection.reg_read_first() == 14)
                {
                    mainLabel.Text = "Pieces going under Press";
                    await Task.Delay(100);
                }
                else if (connection.reg_read_first() == 15)
                {
                    mainLabel.Text = "Pieces going into sorter";
                    await Task.Delay(100);
                }
                else if (connection.reg_read_first() == 16)
                {
                    mainLabel.Text = "Oczekiwanie na kolejne zadanie";
                    connection.reg_clr(0);
                    progressBar1.Value = 100;
                    MessageBox.Show("Success");
                    await Task.Delay(100);
                    break;
                }
                await Task.Delay(100);
            }
            return;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.DissConnect();
        }
    }
}