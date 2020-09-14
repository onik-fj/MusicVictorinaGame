using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicVictorinaGame
{
    public partial class fMain : Form
    {
        fOption fO = new fOption();
        fGame fG = new fGame();
        public fMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            fO.ShowDialog();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            fG.ShowDialog();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            Victorina.ReadOption();
            Victorina.ReadMusic();
        }
    }
}
