using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MusicVictorinaGame
{
    public partial class fOption : Form
    {
        public fOption()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Victorina.allDirectories = checkBoxPath.Checked;
            Victorina.gameDuration = Convert.ToInt32(comboBoxLeightGame.Text);
            Victorina.musicDuration = Convert.ToInt32(comboBoxtlCallback.Text);
            Victorina.randomStart = checkBoxRandomStart.Checked;
            Victorina.WriteOption();
            this.Hide();
        }

        void Set()
        {
            checkBoxPath.Checked = Victorina.allDirectories;
            comboBoxLeightGame.Text = Victorina.gameDuration.ToString();
            comboBoxtlCallback.Text = Victorina.musicDuration.ToString();
            checkBoxRandomStart.Checked = Victorina.randomStart;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Set();
            this.Hide();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] musicList = Directory.GetFiles(fbd.SelectedPath, "*.mp3",checkBoxPath.Checked?SearchOption.AllDirectories: SearchOption.TopDirectoryOnly);
                Victorina.lastFolder = fbd.SelectedPath;
                listBoxTrack.Items.Clear();
                listBoxTrack.Items.AddRange(musicList);
                Victorina.list.Clear();
                Victorina.list.AddRange(musicList);
            }
        }

        private void fOption_Load(object sender, EventArgs e)
        {
            Set();
            listBoxTrack.Items.Clear();
            listBoxTrack.Items.AddRange(Victorina.list.ToArray());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
