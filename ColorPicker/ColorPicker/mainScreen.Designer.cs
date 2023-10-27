namespace ColorPicker
{
    partial class mainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            roundedPanelx1 = new PanelD.RoundedPanelx();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(12, 133);
            label1.Name = "label1";
            label1.Size = new Size(260, 15);
            label1.TabIndex = 0;
            label1.Text = "(HEX) Color:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 180);
            button1.Name = "button1";
            button1.Size = new Size(260, 23);
            button1.TabIndex = 3;
            button1.Text = "Hold press and select";
            button1.UseVisualStyleBackColor = true;
            button1.MouseDown += button1_MouseDown;
            button1.MouseUp += button1_MouseUp;
            // 
            // roundedPanelx1
            // 
            roundedPanelx1.BackColor = SystemColors.ButtonFace;
            roundedPanelx1.Location = new Point(12, 28);
            roundedPanelx1.Name = "roundedPanelx1";
            roundedPanelx1.Size = new Size(260, 102);
            roundedPanelx1.TabIndex = 4;
            roundedPanelx1.Text = "roundedPanelx1";
            // 
            // label2
            // 
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(260, 15);
            label2.TabIndex = 5;
            label2.Text = "(Image) Color:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 213);
            Controls.Add(label2);
            Controls.Add(roundedPanelx1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "mainScreen";
            Text = "ColorPicker";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private PanelD.RoundedPanelx roundedPanelx1;
        private Label label2;
    }
}