using Minesweeper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Registo : Form
    {
        Server servidor = null;
        public Registo()
        {
            InitializeComponent();
            servidor = new Server();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tab inicioregisto = new Tab();
            this.Hide();
            inicioregisto.ShowDialog();
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem a certeza que pretende sair da aplicação?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
                Application.Exit();
        }

        private void linkLabelRegistar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CriarConta cr = new CriarConta();
            cr.ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string id = string.Empty;
            servidor = new Server();

            id = servidor.Login(textBoxUsername.Text, textBoxPass.Text);
            
            if (!string.IsNullOrEmpty(id))
            {
                Program.ID = id;
                Program.User = textBoxUsername.Text;
                Tab inicioregisto = new Tab();
                this.Hide();
                inicioregisto.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login nao efetuado! Conta invalida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }
    }
}