using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Ajuda : Form
    {
        public Ajuda()
        {
            InitializeComponent();
        }

        private void buttonFecharAjuda_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://pt.wikipedia.org/wiki/Campo_minado");
        }
    }
}
