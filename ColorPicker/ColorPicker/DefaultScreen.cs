using ColorPicker.Class;
using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;

namespace ColorPicker
{
    public partial class DefaultScreen : Form
    {
        public static bool _buttonIsPressed;

        public DefaultScreen()
        {
            InitializeComponent();
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
                    roundedPanel2.BackColor = GetColor.getColor(Cursor.Position);
                    roundedLabel1.Text = ColorTranslator.ToHtml(GetColor.getColor(Cursor.Position));
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

        private async void roundedButton2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(roundedLabel1.Text);
            roundedButton2.Text = "Copied!";
            await Task.Delay(1500);
            roundedButton2.Text = "Copy";
        }
    }
}
