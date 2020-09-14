using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MusicVictorinaGame
{
    public partial class fGame : Form
    {
        Random rnd = new Random(); 
        int musicDuration=Victorina.musicDuration;
        bool[] player = new bool[2];
        public fGame()
        {
            InitializeComponent();
        }

        void MakeMusic()
        {
            if (Victorina.list.Count == 0) EndGame();
            else
            {
                musicDuration = Victorina.musicDuration;
                int n = rnd.Next(0, Victorina.list.Count);
                WMP.URL = Victorina.list[n];
                Victorina.answer = System.IO.Path.GetFileNameWithoutExtension(WMP.URL);
                WMP.Ctlcontrols.play(); //если проигрыватель не воспроизводит
                Victorina.list.RemoveAt(n);
                labelMelodyCount.Text = Victorina.list.Count.ToString();
                player[0] = false;
                player[1] = false;
            }
        }
        private void btnNextTrack_Click(object sender, EventArgs e)
        {
            lShowAnswer.Text="Показать ответ";
            timer1.Start();
            MakeMusic();
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            labelMelodyCount.Text = Victorina.list.Count.ToString();
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = Victorina.gameDuration;
            lCountMusicDutarion.Text = musicDuration.ToString();
        }

        void EndGame()
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            musicDuration--;
            lCountMusicDutarion.Text = musicDuration.ToString();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                EndGame();
                return;
            }

            if (musicDuration == 0)
            {
                MakeMusic();
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            WMP.Ctlcontrols.pause();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            timer1.Start();
            WMP.Ctlcontrols.play();
        }

        void GamePause()
        {
            timer1.Stop();
            WMP.Ctlcontrols.pause();
        }

        void GamePlay()
        {
            timer1.Start();
            WMP.Ctlcontrols.play();
        }
        private void fGame_KeyDown(object sender, KeyEventArgs e)
        {
            if(!timer1.Enabled)return;
            if (player[0] == false && e.KeyData == Keys.A)
            {
                GamePause();
                player[0] = true;
                if (MessageBox.Show("Правильный ответ?", "Игрок1", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    labelNum1.Text = Convert.ToString(Convert.ToInt32(labelNum1.Text) + 1);
                    MakeMusic();
                }
                GamePlay();
            }
            if (player[1] == false && e.KeyData == Keys.P)
            {
                GamePause();
                player[1] = true;
                if (MessageBox.Show("Правильный ответ?", "Игрок2", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    labelNum2.Text = Convert.ToString(Convert.ToInt32(labelNum2.Text) + 1);
                    MakeMusic();
                }
                GamePlay();
            }
        }

        private void WMP_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Victorina.randomStart)
            {
                if (WMP.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                {
                    WMP.Ctlcontrols.currentPosition = rnd.Next(0, (int) WMP.currentMedia.duration / 2);
                }
            }
        }

        private void labelNum1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left) labelNum1.Text = Convert.ToString(Convert.ToInt32(labelNum1.Text) + 1);
            if (e.Button == MouseButtons.Right) labelNum1.Text = Convert.ToString(Convert.ToInt32(labelNum1.Text) - 1);
        }

        private void labelNum2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) labelNum2.Text = Convert.ToString(Convert.ToInt32(labelNum2.Text) + 1);
            if (e.Button == MouseButtons.Right) labelNum2.Text = Convert.ToString(Convert.ToInt32(labelNum2.Text) - 1);
        }

        private void lShowAnswer_Click(object sender, EventArgs e)
        {
            lShowAnswer.Text = Victorina.answer;
        }
    }
}