using prevacCompetition_desktopAppWinForms;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button run;
            this.connectb = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.TextBox();
            this.IpConn = new System.Windows.Forms.TextBox();
            this.PortConn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.typeOfKronzkas = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.mainLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.serial = new System.Windows.Forms.TextBox();
            run = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // run
            // 
            run.ForeColor = System.Drawing.Color.Red;
            run.Location = new System.Drawing.Point(303, 299);
            run.Name = "run";
            run.Size = new System.Drawing.Size(145, 42);
            run.TabIndex = 0;
            run.Text = "start";
            run.UseVisualStyleBackColor = true;
            run.Click += new System.EventHandler(this.run_Click);
            // 
            // connectb
            // 
            this.connectb.ForeColor = System.Drawing.Color.Red;
            this.connectb.Location = new System.Drawing.Point(597, 299);
            this.connectb.Name = "connectb";
            this.connectb.Size = new System.Drawing.Size(145, 42);
            this.connectb.TabIndex = 0;
            this.connectb.Text = "Not Connected";
            this.connectb.UseVisualStyleBackColor = true;
            this.connectb.Click += new System.EventHandler(this.connect_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(597, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "dodaj nowy kronzek";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(392, 139);
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Size = new System.Drawing.Size(100, 20);
            this.quantity.TabIndex = 1;
            // 
            // IpConn
            // 
            this.IpConn.Location = new System.Drawing.Point(542, 170);
            this.IpConn.Name = "IpConn";
            this.IpConn.Size = new System.Drawing.Size(100, 20);
            this.IpConn.TabIndex = 1;
            this.IpConn.Text = "192.168.1.116";
            this.IpConn.TextChanged += new System.EventHandler(this.IpConn_TextChanged);
            // 
            // PortConn
            // 
            this.PortConn.Location = new System.Drawing.Point(542, 238);
            this.PortConn.Name = "PortConn";
            this.PortConn.Size = new System.Drawing.Size(100, 20);
            this.PortConn.TabIndex = 1;
            this.PortConn.Text = "12345";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "kolor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(389, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ilość";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(539, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "port";
            // 
            // typeOfKronzkas
            // 
            this.typeOfKronzkas.FormattingEnabled = true;
            this.typeOfKronzkas.Location = new System.Drawing.Point(247, 137);
            this.typeOfKronzkas.Name = "typeOfKronzkas";
            this.typeOfKronzkas.Size = new System.Drawing.Size(121, 21);
            this.typeOfKronzkas.TabIndex = 3;
            this.typeOfKronzkas.SelectedIndexChanged += new System.EventHandler(this.typeOfKronzkas_SelectedIndexChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(247, 218);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(245, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Location = new System.Drawing.Point(315, 202);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(123, 13);
            this.mainLabel.TabIndex = 5;
            this.mainLabel.Text = "Oczekiwanie na zadanie";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(613, 114);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "use TCP";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(673, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "COM";
            // 
            // serial
            // 
            this.serial.Location = new System.Drawing.Point(667, 204);
            this.serial.Name = "serial";
            this.serial.Size = new System.Drawing.Size(100, 20);
            this.serial.TabIndex = 7;
            this.serial.Text = "COM5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.serial);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.typeOfKronzkas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PortConn);
            this.Controls.Add(this.IpConn);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.connectb);
            this.Controls.Add(run);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


      
        #endregion
        void connect()
        {
            if (checkBox1.Checked)
            {
                connection.connectUsingTcp = true;
                connection.set(this.IpConn.Text, int.Parse(this.PortConn.Text));
            }
            else
            {
                connection.connectUsingTcp = false;
                connection.set(serial.Text);
            }
            connection.Connect();
            return;
        }
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox IpConn;
        private System.Windows.Forms.TextBox PortConn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox typeOfKronzkas;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button connectb;
        private Label mainLabel;
        private CheckBox checkBox1;
        private Label label5;
        private TextBox serial;
    }
}

