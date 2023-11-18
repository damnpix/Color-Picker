namespace Color_Picker
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundedButton4 = new Color_Picker.Scripts.UI.RoundedButton();
            this.roundedButton3 = new Color_Picker.Scripts.UI.RoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedLabel2 = new Color_Picker.Scripts.UI.RoundedLabel();
            this.roundedPanel1 = new Color_Picker.Scripts.UI.RoundedPanel();
            this.roundedButton1 = new Color_Picker.Scripts.UI.RoundedButton();
            this.roundedButton2 = new Color_Picker.Scripts.UI.RoundedButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.roundedButton4);
            this.panel1.Controls.Add(this.roundedButton3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 29);
            this.panel1.TabIndex = 0;
            // 
            // roundedButton4
            // 
            this.roundedButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.roundedButton4.cornerRadiusX = 10;
            this.roundedButton4.cornerRadiusY = 10;
            this.roundedButton4.FlatAppearance.BorderSize = 0;
            this.roundedButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.roundedButton4.Image = global::Color_Picker.Properties.Resources.settings;
            this.roundedButton4.Location = new System.Drawing.Point(126, 3);
            this.roundedButton4.Name = "roundedButton4";
            this.roundedButton4.Size = new System.Drawing.Size(31, 23);
            this.roundedButton4.TabIndex = 2;
            this.roundedButton4.Text = "\r\n";
            this.roundedButton4.UseVisualStyleBackColor = false;
            this.roundedButton4.Click += new System.EventHandler(this.roundedButton4_Click);
            // 
            // roundedButton3
            // 
            this.roundedButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.roundedButton3.cornerRadiusX = 10;
            this.roundedButton3.cornerRadiusY = 10;
            this.roundedButton3.FlatAppearance.BorderSize = 0;
            this.roundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.roundedButton3.Image = global::Color_Picker.Properties.Resources.close;
            this.roundedButton3.Location = new System.Drawing.Point(161, 3);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.Size = new System.Drawing.Size(31, 23);
            this.roundedButton3.TabIndex = 1;
            this.roundedButton3.Text = "\r\n";
            this.roundedButton3.UseVisualStyleBackColor = false;
            this.roundedButton3.Click += new System.EventHandler(this.roundedButton3_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(126)))), ((int)(((byte)(127)))));
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color Picker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundedLabel2
            // 
            this.roundedLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.roundedLabel2.cornerRadiusX = 10;
            this.roundedLabel2.cornerRadiusY = 10;
            this.roundedLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.roundedLabel2.Location = new System.Drawing.Point(4, 35);
            this.roundedLabel2.Name = "roundedLabel2";
            this.roundedLabel2.Size = new System.Drawing.Size(69, 27);
            this.roundedLabel2.TabIndex = 2;
            this.roundedLabel2.Text = "#676767";
            this.roundedLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.roundedPanel1.cornerRadiusX = 10;
            this.roundedPanel1.cornerRadiusY = 10;
            this.roundedPanel1.Location = new System.Drawing.Point(75, 35);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(73, 27);
            this.roundedPanel1.TabIndex = 3;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(77)))), ((int)(((byte)(150)))));
            this.roundedButton1.cornerRadiusX = 10;
            this.roundedButton1.cornerRadiusY = 10;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.roundedButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton1.Location = new System.Drawing.Point(4, 65);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(186, 23);
            this.roundedButton1.TabIndex = 4;
            this.roundedButton1.Text = "Select";
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(77)))), ((int)(((byte)(150)))));
            this.roundedButton2.cornerRadiusX = 10;
            this.roundedButton2.cornerRadiusY = 10;
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.roundedButton2.Image = global::Color_Picker.Properties.Resources.copy;
            this.roundedButton2.Location = new System.Drawing.Point(149, 35);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(41, 27);
            this.roundedButton2.TabIndex = 5;
            this.roundedButton2.UseVisualStyleBackColor = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(195, 95);
            this.Controls.Add(this.roundedButton2);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.roundedLabel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private Color_Picker.Scripts.UI.RoundedButton roundedButton4;

        private Color_Picker.Scripts.UI.RoundedButton roundedButton3;

        private Color_Picker.Scripts.UI.RoundedButton roundedButton2;

        private System.Windows.Forms.Label label1;

        private Color_Picker.Scripts.UI.RoundedLabel roundedLabel2;

        private Color_Picker.Scripts.UI.RoundedPanel roundedPanel1;
        private Color_Picker.Scripts.UI.RoundedButton roundedButton1;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}
