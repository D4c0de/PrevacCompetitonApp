using prevacCompetition_desktopAppWinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{   
    public partial class Form2 : Form
    {
        private ComboBox.ObjectCollection _objects;
        public Form2(ComboBox.ObjectCollection objects)
        {
            _objects = objects;
            InitializeComponent();
        }

        private void addNew_Click(object sender, EventArgs e)
        {
            if (connection.isRunning)
            {
                MessageBox.Show("Curently not avilable :( \nend last task firstly");
                return;
            }
            string color=this.addColor.Text; //Color
            if (string.IsNullOrWhiteSpace(color))
            {
                MessageBox.Show("Please enter a valid color.");
                return;
            }
            int[] col = new int[color.Length];
            for (int i = 0; i < color.Length; i++)
            {
                col[i] = (int)color[i];
            }


            if (string.IsNullOrWhiteSpace(this.targetHeat.Text)) //Target temperature
            {
                MessageBox.Show("Please enter a valid temperature.");
                return;
            }
            float targetTemperatureValue;
            if (!float.TryParse(this.targetHeat.Text, out targetTemperatureValue))
            {
                MessageBox.Show("Please enter a valid temperature.");
                return;
            }
            targetTemperatureValue = targetTemperatureValue * 10;


            if (string.IsNullOrWhiteSpace(this.mass.Text))//Mass
            {
                MessageBox.Show("Please enter a valid heat.");
            }
            int mass;
            if (!int.TryParse(this.mass.Text, out mass))
            {
                MessageBox.Show("Please enter a valid heat.");
                return;
            }


            if (string.IsNullOrWhiteSpace(this.Size.Text))//Size
            {
                MessageBox.Show("Please enter a valid heat.");
            }
            int size;
            if (!int.TryParse(this.Size.Text, out size))
            {
                MessageBox.Show("Please enter a valid heat.");
                return;
            }


            if (string.IsNullOrWhiteSpace(this.specificHeat.Text))//Specific heat
            {
                MessageBox.Show("Please enter a valid heat.");
            }
            int SpecyficHeat;
            if (!int.TryParse(this.specificHeat.Text, out SpecyficHeat))
            {
                MessageBox.Show("Please enter a valid heat.");
                return;
            }
            _objects.Add(color);


            addNewPieces(col, SpecyficHeat,mass,(int)targetTemperatureValue,size);
        }
        private void addNewPieces(int[] col,int heat,int mass,int temp,int size) {
            connection.reg_write_first(2);
            connection.reg_write_multiply(1, col);
            int[] temporary = new int[4] { heat, mass, temp, size };
            connection.reg_write_multiply(10, temporary);
            MessageBox.Show("Succes");
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
