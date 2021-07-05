using Minesweeper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Minesweeper
{
    public partial class VerPerfis : Form
    {
        Server serverPerfis = null;
        XDocument resposta = null;
        public VerPerfis()
        {
            InitializeComponent();
            logadoComoPerfis();
        }

        private void logadoComoPerfis()
        {
            if (!string.IsNullOrEmpty(Program.User))
            {
               labelUserPerfis.Text = Program.User;
            }
            else
            {
               labelUserPerfis.Text = "Offline";
            }
           
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            serverPerfis = new Server();
            resposta = new XDocument();
            resposta = serverPerfis.GetPerfil(textBoxPesquisaUser.Text);
           

            try
            {
                string status = resposta.Element("resultado").Element("status").Value;
                string contexto = resposta.Element("resultado").Element("contexto").Value;
                if (status == "ERRO"){
                    MessageBox.Show(contexto);
                }
                else
                {
                    labelNomeAbreviado.Text = resposta.Element("resultado").Element("objeto").Element("perfil").Element("nomeabreviado").Value;
                    labelEmail.Text = resposta.Element("resultado").Element("objeto").Element("perfil").Element("email").Value;
                    labelPais.Text = resposta.Element("resultado").Element("objeto").Element("perfil").Element("pais").Value;

                    labelNumJogosGanhos.Text = resposta.Element("resultado").Element("objeto").Element("perfil").Element("jogos").Element("ganhos").Value;
                    labelNumJogosPerdidos.Text = resposta.Element("resultado").Element("objeto").Element("perfil").Element("jogos").Element("perdidos").Value;

                    if (resposta.Element("resultado").Element("objeto").Element("perfil").Element("tempos").Element("Facil") == null)
                    {

                        labelMelhorTempoFacil.Text = "Nao definido";
                    }
                    else
                    {
                        labelMelhorTempoFacil.Text = resposta.Element("resultado").Element("objeto").Element("perfil").Element("tempos").Element("Facil").Value;
                    }


                    if (resposta.Element("resultado").Element("objeto").Element("perfil").Element("tempos").Element("Medio") == null)
                    {
                        labelMelhorTempoMedio.Text = "Nao definido";
                    }
                    else
                    {
                        labelMelhorTempoMedio.Text = resposta.Element("resultado").Element("objeto").Element("perfil").Element("tempos").Element("Medio").Value;
                    }



                    string base64Imagem = resposta.Element("resultado").Element("objeto").Element("perfil").Element("fotografia").Value;
                    string base64 = base64Imagem.Split(',')[1];
                    byte[] bytes = Convert.FromBase64String(base64);
                    Image image = Image.FromStream(new MemoryStream(bytes));
                    pictureBoxFoto.BackgroundImageLayout = ImageLayout.Zoom;
                    pictureBoxFoto.BackgroundImage = image;
                }
                
            }
            catch (Exception ex)
            {
                pictureBoxFoto.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBoxFoto.BackgroundImage = Properties.Resources.NoPic;
                
            }
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
