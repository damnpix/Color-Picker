using ColorPicker.Class;
using System;
using System.Threading;

namespace ColorPicker
{
    public partial class mainScreen : Form
    {
        public static bool _buttonIsPressed;

        public mainScreen()
        {
            InitializeComponent();
            roundedPanelx1.BackColor = Color.FromArgb(199, 198, 197);
            textBox1.Text = ColorTranslator.ToHtml(Color.FromArgb(199, 198, 197));
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread bck = new Thread(BackgroundThread)
            { IsBackground = true };

            bck.Start();
        }

        void BackgroundThread()
        {
            while (true)
            {
                if (_buttonIsPressed)
                {
                    roundedPanelx1.BackColor = GetColor.getColor(Cursor.Position);
                    textBox1.Text = ColorTranslator.ToHtml(GetColor.getColor(Cursor.Position));
                }
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Cross;
            _buttonIsPressed = true;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            _buttonIsPressed = false;
            Cursor = Cursors.Default;
        }

    }
}