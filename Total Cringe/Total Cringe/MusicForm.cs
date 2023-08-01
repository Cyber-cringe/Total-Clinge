using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using WMPLib;
using MediaPlayer;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using System.Media;
using System.Reflection.Emit;

namespace Total_Cringe
{
    public partial class MusicForm : Form
    {
        string filis;
        Image playimage = Properties.Resources.Music_comtent1;
        Image pauseimage = Properties.Resources.Music_comtent2;
        bool ppause = false;
        bool playing = false;
        public MusicForm(string file)
        {
            InitializeComponent();
            player.controls.play();
            timer1.Interval = 1000;
            filis = file;
            button1.BackgroundImage = playimage;
        }
        public bool IsPlaying()
        {
            if (player.playState == WMPPlayState.wmppsPlaying)
            {
                return true;
            }
            return false;
        }
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        bool firstStart = true;
        private void button1_Click(object sender, EventArgs e)
        {

            bool playtest = IsPlaying();

            if(playtest)
            {
                player.controls.pause();
                button1.BackgroundImage = playimage;
            }
            if(!playtest)
            {
                if (firstStart)
                {
                    player.URL = filis;
                    timer1.Start();
                    firstStart = false;
                }
                player.controls.play();
                button1.BackgroundImage = pauseimage;    
                return;
            }
        }

        private void MusicForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            player.controls.stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            player.controls.stop();
            button1.BackgroundImage = playimage;
            firstStart = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            trackBar1.Maximum = Convert.ToInt32(player.currentMedia.duration);
            trackBar1.Value = Convert.ToInt32(player.controls.currentPosition);

            if (player != null)
            {
                int s = (int)player.currentMedia.duration;
                int h = s / 3600;
                int m = (s - (h * 3600)) / 60;
                s = s - (h * 3600 + m * 60);
                label2.Text = String.Format("{0:D}:{1:D2}:{2:D2}", h, m, s);

                s = (int)player.controls.currentPosition;
                h = s / 3600;
                m = (s - (h * 3600)) / 60;
                s = s - (h * 3600 + m * 60);
                label1.Text = String.Format("{0:D}:{1:D2}:{2:D2}", h, m, s);
            }
            else
            {
                label2.Text = "0:00:00";
                label1.Text = "0:00:00";
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.controls.currentPosition = trackBar1.Value;
        }

        private void MusicForm_Load(object sender, EventArgs e)
        {
        }
    }

}
