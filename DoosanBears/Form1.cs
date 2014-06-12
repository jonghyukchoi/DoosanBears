using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Collections;

namespace DoosanBears
{
    public partial class Form1 : Form
    {
        private SoundPlayer soundPlayer;
        private Bitmap Hong = Properties.Resources.홍성흔0;
        private int cell = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap("Jamsil.jpg");
            this.BackgroundImage = bitmap;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void 구단응원가ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void 빠라빠빠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer(Properties.Resources.빠라빠빠);
            soundPlayer.Play();
            soundPlayer.PlayLooping();
            // 음악 재생될 때 재생시간이나 가사 보여줄 수 있는 방법 알아볼 것.
        }

        private void 해냈다두산ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer(Properties.Resources.해냈다두산);
            soundPlayer.Play();
            soundPlayer.PlayLooping();
            // 음악 재생될 때 재생시간이나 가사 보여줄 수 있는 방법 알아볼 것.
        }

        private void 승리의두산ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer(Properties.Resources.승리의두산);
            soundPlayer.Play();
            soundPlayer.PlayLooping();
            // 음악 재생될 때 재생시간이나 가사 보여줄 수 있는 방법 알아볼 것.
        }

        private void 홍성흔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            timer1.Start();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Hong, 10, 10, Hong.Width, Hong.Height);
            e.Graphics.DrawImage(Hong, 100, 60, Hong.Width, Hong.Height);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (cell)
            {
                case 0: Hong = Properties.Resources.홍성흔0;
                    break;
                case 1: Hong = Properties.Resources.홍성흔1;
                    break;
                case 2: Hong = Properties.Resources.홍성흔2;
                    break;
                case 3: Hong = Properties.Resources.홍성흔3;
                    break;
                case 4: Hong = Properties.Resources.홍성흔4;
                    break;
                case 5: Hong = Properties.Resources.홍성흔5;
                    break;
                case 6: Hong = Properties.Resources.홍성흔6;
                    break;
                case 7: Hong = Properties.Resources.홍성흔7;
                    break;
                case 8: Hong = Properties.Resources.홍성흔8;
                    break;
                case 9: Hong = Properties.Resources.홍성흔9;
                    cell = 0;
                    break;
            }
            Invalidate();
        }
    }
}
