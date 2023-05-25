namespace WindowsFormsApp1
{
    partial class Auth
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.accept = new System.Windows.Forms.Button();
            this.option = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.useTCP = new System.Windows.Forms.Panel();
            this.PortConn = new System.Windows.Forms.TextBox();
            this.IpConn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.useRTU = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.serial = new System.Windows.Forms.TextBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.settingsPanel.SuspendLayout();
            this.useTCP.SuspendLayout();
            this.useRTU.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(45, 71);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(100, 20);
            this.login.TabIndex = 0;

            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(45, 137);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(45, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(45, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "password:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(203, 40);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(124, 23);
            this.connect.TabIndex = 5;
            this.connect.Text = "Connect Options";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.accept);
            this.settingsPanel.Controls.Add(this.option);
            this.settingsPanel.Controls.Add(this.label3);
            this.settingsPanel.Controls.Add(this.useTCP);
            this.settingsPanel.Controls.Add(this.useRTU);
            this.settingsPanel.Location = new System.Drawing.Point(36, 21);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(344, 295);
            this.settingsPanel.TabIndex = 27;
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(128, 232);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(124, 23);
            this.accept.TabIndex = 6;
            this.accept.Text = "Accept ";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // option
            // 
            this.option.FormattingEnabled = true;
            this.option.Items.AddRange(new object[] {
            "RTU",
            "TCP"});
            this.option.Location = new System.Drawing.Point(141, 37);
            this.option.Name = "option";
            this.option.Size = new System.Drawing.Size(121, 21);
            this.option.TabIndex = 25;
            this.option.Text = "RTU";
            this.option.SelectedIndexChanged += new System.EventHandler(this.Option_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(104, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Use :";
            // 
            // useTCP
            // 
            this.useTCP.Controls.Add(this.PortConn);
            this.useTCP.Controls.Add(this.IpConn);
            this.useTCP.Controls.Add(this.label4);
            this.useTCP.Controls.Add(this.label5);
            this.useTCP.Location = new System.Drawing.Point(100, 64);
            this.useTCP.Name = "useTCP";
            this.useTCP.Size = new System.Drawing.Size(173, 143);
            this.useTCP.TabIndex = 23;
            // 
            // PortConn
            // 
            this.PortConn.Location = new System.Drawing.Point(41, 104);
            this.PortConn.Name = "PortConn";
            this.PortConn.Size = new System.Drawing.Size(100, 20);
            this.PortConn.TabIndex = 16;
            this.PortConn.Text = "12345";
            // 
            // IpConn
            // 
            this.IpConn.Location = new System.Drawing.Point(41, 36);
            this.IpConn.Name = "IpConn";
            this.IpConn.Size = new System.Drawing.Size(100, 20);
            this.IpConn.TabIndex = 17;
            this.IpConn.Text = "192.168.1.116";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(47, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "ip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(38, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "port";
            // 
            // useRTU
            // 
            this.useRTU.Controls.Add(this.label6);
            this.useRTU.Controls.Add(this.serial);
            this.useRTU.Location = new System.Drawing.Point(100, 66);
            this.useRTU.Name = "useRTU";
            this.useRTU.Size = new System.Drawing.Size(173, 137);
            this.useRTU.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(38, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "COM";
            // 
            // serial
            // 
            this.serial.Location = new System.Drawing.Point(41, 48);
            this.serial.Name = "serial";
            this.serial.Size = new System.Drawing.Size(100, 20);
            this.serial.TabIndex = 21;
            this.serial.Text = "COM6";
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.password);
            this.loginPanel.Controls.Add(this.login);
            this.loginPanel.Controls.Add(this.connect);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Controls.Add(this.button1);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Location = new System.Drawing.Point(33, 24);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(345, 295);
            this.loginPanel.TabIndex = 28;
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(419, 338);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.settingsPanel);
            this.Name = "Auth";
            this.Text = "Auth";
            this.Load += new System.EventHandler(this.Auth_Load);
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.useTCP.ResumeLayout(false);
            this.useTCP.PerformLayout();
            this.useRTU.ResumeLayout(false);
            this.useRTU.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.ComboBox option;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel useTCP;
        private System.Windows.Forms.TextBox PortConn;
        private System.Windows.Forms.TextBox IpConn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel useRTU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox serial;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button accept;
    }
}