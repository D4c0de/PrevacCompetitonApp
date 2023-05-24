namespace WindowsFormsApp1
{
    partial class Form2
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
            this.addNew = new System.Windows.Forms.Button();
            this.targetTemperature = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.targetHeat = new System.Windows.Forms.TextBox();
            this.addColor = new System.Windows.Forms.TextBox();
            this.mass = new System.Windows.Forms.TextBox();
            this.sadasdas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.specificHeat = new System.Windows.Forms.TextBox();
            this.Size = new System.Windows.Forms.TextBox();
            this.qwe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addNew
            // 
            this.addNew.ForeColor = System.Drawing.Color.Black;
            this.addNew.Location = new System.Drawing.Point(102, 292);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(156, 23);
            this.addNew.TabIndex = 1;
            this.addNew.Text = "dodaj nowy kronzek";
            this.addNew.UseVisualStyleBackColor = true;
            this.addNew.Click += new System.EventHandler(this.addNew_Click);
            // 
            // targetTemperature
            // 
            this.targetTemperature.AutoSize = true;
            this.targetTemperature.ForeColor = System.Drawing.Color.Transparent;
            this.targetTemperature.Location = new System.Drawing.Point(177, 36);
            this.targetTemperature.Name = "targetTemperature";
            this.targetTemperature.Size = new System.Drawing.Size(125, 13);
            this.targetTemperature.TabIndex = 5;
            this.targetTemperature.Text = "docelowa temperatura *c";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "kolor";
            // 
            // targetHeat
            // 
            this.targetHeat.Location = new System.Drawing.Point(180, 57);
            this.targetHeat.Name = "targetHeat";
            this.targetHeat.Size = new System.Drawing.Size(100, 20);
            this.targetHeat.TabIndex = 4;
            // 
            // addColor
            // 
            this.addColor.Location = new System.Drawing.Point(44, 57);
            this.addColor.Name = "addColor";
            this.addColor.Size = new System.Drawing.Size(100, 20);
            this.addColor.TabIndex = 7;
            // 
            // mass
            // 
            this.mass.Location = new System.Drawing.Point(44, 140);
            this.mass.Name = "mass";
            this.mass.Size = new System.Drawing.Size(100, 20);
            this.mass.TabIndex = 11;
            this.mass.Text = "20";
            // 
            // sadasdas
            // 
            this.sadasdas.AutoSize = true;
            this.sadasdas.ForeColor = System.Drawing.Color.Transparent;
            this.sadasdas.Location = new System.Drawing.Point(37, 195);
            this.sadasdas.Name = "sadasdas";
            this.sadasdas.Size = new System.Drawing.Size(107, 13);
            this.sadasdas.TabIndex = 9;
            this.sadasdas.Text = "ciepło własciwe j/kg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "masa Gram";
            // 
            // specificHeat
            // 
            this.specificHeat.Location = new System.Drawing.Point(40, 216);
            this.specificHeat.Name = "specificHeat";
            this.specificHeat.Size = new System.Drawing.Size(100, 20);
            this.specificHeat.TabIndex = 8;
            this.specificHeat.Text = "1000";
            // 
            // Size
            // 
            this.Size.Location = new System.Drawing.Point(180, 140);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(100, 20);
            this.Size.TabIndex = 13;
            this.Size.Text = "1";
            // 
            // qwe
            // 
            this.qwe.AutoSize = true;
            this.qwe.ForeColor = System.Drawing.Color.White;
            this.qwe.Location = new System.Drawing.Point(177, 119);
            this.qwe.Name = "qwe";
            this.qwe.Size = new System.Drawing.Size(61, 13);
            this.qwe.TabIndex = 12;
            this.qwe.Text = "promień cm";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(346, 337);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.qwe);
            this.Controls.Add(this.mass);
            this.Controls.Add(this.sadasdas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.specificHeat);
            this.Controls.Add(this.addColor);
            this.Controls.Add(this.targetTemperature);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.targetHeat);
            this.Controls.Add(this.addNew);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNew;
        private System.Windows.Forms.Label targetTemperature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox targetHeat;
        private System.Windows.Forms.TextBox addColor;
        private System.Windows.Forms.TextBox mass;
        private System.Windows.Forms.Label sadasdas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox specificHeat;
        private System.Windows.Forms.TextBox Size;
        private System.Windows.Forms.Label qwe;
    }
}