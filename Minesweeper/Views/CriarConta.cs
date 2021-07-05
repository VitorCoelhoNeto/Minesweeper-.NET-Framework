using Minesweeper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class CriarConta : Form
    {
        Server server = null;
        public CriarConta()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '●';
        }
        
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem a certeza que deseja sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
                Application.Exit();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buttonCriar_Click(object sender, EventArgs e)
        {
            server = new Server();
            if (textBoxNome.Text.Length <= 10 && textBoxNome.Text.Length > 0)
            {
                if (textBoxUsername.Text.Length <= 10 && textBoxUsername.Text.Length > 0)
                {
                    if (textBoxPassword.Text.Length <= 20 && textBoxPassword.Text.Length >= 5 && (textBoxPassword.Text.Contains('0') || textBoxPassword.Text.Contains('1') || textBoxPassword.Text.Contains('2') || textBoxPassword.Text.Contains('3') || textBoxPassword.Text.Contains('4') || textBoxPassword.Text.Contains('5') || textBoxPassword.Text.Contains('6') || textBoxPassword.Text.Contains('7') || textBoxPassword.Text.Contains('8') || textBoxPassword.Text.Contains('9')))
                    {
                        if (textBoxEmail.Text.Length > 0 && textBoxEmail.Text.Contains('@') && textBoxEmail.Text.Contains('.'))
                        {
                            if (comboBoxPais.SelectedItem != null)
                            {
                                server.RegistarNovoUtilizador(textBoxUsername.Text, textBoxNome.Text, textBoxPassword.Text, textBoxEmail.Text, textBoxFoto.Text ,comboBoxPais.Text);

                                this.Hide();

                            }
                            else if (comboBoxPais.SelectedItem == null)
                            {
                                MessageBox.Show("País inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (!textBoxEmail.Text.Contains('@') || !textBoxEmail.Text.Contains('.') || textBoxEmail.Text.Length > 0)
                        {
                            MessageBox.Show("Email inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxEmail.Text = null;
                        }
                    }
                    else if (textBoxPassword.Text.Length > 20)
                    {
                        MessageBox.Show("A password é demasiado longa!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxPassword.Text = null;
                    }
                    else if (textBoxPassword.Text.Length < 5)
                    {
                        MessageBox.Show("A password é demasiado curta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxPassword.Text = null;
                    }
                    else
                    {
                        MessageBox.Show("A password deve conter pelo menos 1 numero!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxPassword.Text = null;
                    }
                }
                else if (textBoxUsername.Text.Length > 10)
                {

                    MessageBox.Show("Username demasiado longo! Insira de novo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxUsername.Text = null;
                }
                else if (textBoxUsername.Text.Length <= 0)
                {
                    MessageBox.Show("Username demasiado curto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxUsername.Text = null;
                }
            }
            else if (textBoxNome.Text.Length > 10)
            {

                MessageBox.Show("Nome demasiado longo! Insira de novo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNome.Text = null;
            }
            else if (textBoxNome.Text.Length <= 0)
            {
                MessageBox.Show("Nome demasiado curto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNome.Text = null;
            }
        }

        private void linkLabelBase64_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.base64-image.de");
        }
    }
}