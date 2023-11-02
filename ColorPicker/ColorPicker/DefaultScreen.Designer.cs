namespace ColorPicker
{
    partial class DefaultScreen
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefaultScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roundedButton2 = new ColorPicker.Visual.RoundedButton();
            this.roundedLabel1 = new ColorPicker.Visual.RoundedLabel();
            this.roundedButton1 = new ColorPicker.Visual.RoundedButton();
            this.roundedPanel2 = new ColorPicker.Visual.RoundedPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hex Code:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Color:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundedButton2
            // 
            this.roundedButton2._cornerRadiusX = 15;
            this.roundedButton2._cornerRadiusY = 15;
            this.roundedButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.roundedButton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.roundedButton2.Location = new System.Drawing.Point(12, 151);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(79, 26);
            this.roundedButton2.TabIndex = 10;
            this.roundedButton2.Text = "Copy";
            this.roundedButton2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.roundedButton2.UseVisualStyleBackColor = false;
            this.roundedButton2.Click += new System.EventHandler(this.roundedButton2_Click);
            // 
            // roundedLabel1
            // 
            this.roundedLabel1._cornerRadiusX = 15;
            this.roundedLabel1._cornerRadiusY = 15;
            this.roundedLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.roundedLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundedLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.roundedLabel1.Location = new System.Drawing.Point(97, 152);
            this.roundedLabel1.Name = "roundedLabel1";
            this.roundedLabel1.Size = new System.Drawing.Size(175, 26);
            this.roundedLabel1.TabIndex = 8;
            this.roundedLabel1.Text = "#C7C6C5";
            this.roundedLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.roundedLabel1.UseCompatibleTextRendering = true;
            // 
            // roundedButton1
            // 
            this.roundedButton1._cornerRadiusX = 10;
            this.roundedButton1._cornerRadiusY = 10;
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundedButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.roundedButton1.Location = new System.Drawing.Point(12, 184);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(260, 36);
            this.roundedButton1.TabIndex = 6;
            this.roundedButton1.Text = "Clamp and choose";
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.roundedButton1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // roundedPanel2
            // 
            this.roundedPanel2._cornerRadiusX = 10;
            this.roundedPanel2._cornerRadiusY = 10;
            this.roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(198)))), ((int)(((byte)(197)))));
            this.roundedPanel2.Location = new System.Drawing.Point(12, 28);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(260, 102);
            this.roundedPanel2.TabIndex = 1;
            this.roundedPanel2.Text = "roundedPanel2";
            // 
            // DefaultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(284, 232);
            this.Controls.Add(this.roundedButton2);
            this.Controls.Add(this.roundedLabel1);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundedPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DefaultScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Picker ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Visual.RoundedPanel roundedPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Visual.RoundedButton roundedButton1;
        private Visual.RoundedLabel roundedLabel1;
        private Visual.RoundedButton roundedButton2;
    }
}

