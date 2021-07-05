using Minesweeper.Models;
using System;
using System.Media;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Minesweeper
{
    public partial class Tab : Form
    {
        SoundPlayer playMenu = new SoundPlayer(Properties.Resources.musicaMenu);
        int i = 0;
        Server sI = null;
        XDocument mapa = null;

        public Tab()
        {
            InitializeComponent();
            playMenu.PlayLooping();
            logadoComoMenu();
            pictureBoxSom.Image = Properties.Resources.nosound;
        }
        
        private void logadoComoMenu()
        {
            if (!string.IsNullOrEmpty(Program.User))
            {
                  labelUserMenu.Text = Program.User;
            }
            else
            {
                labelUserMenu.Text = "Offline";
            }
            
        }
        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Tem a certeza que pretende sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
          
        }

        public void buttonJogar_Click(object sender, EventArgs e)
        {

            if (comboBoxModosJogo.Text == "Facil")
            {
                Facil facil = new Facil();
                playMenu.Stop();
                this.Hide();
                facil.ShowDialog();

            }
            else if (comboBoxModosJogo.Text == "Intermedio")
            {
                playMenu.Stop();
                Intermedio medio = new Intermedio();
                this.Hide();
                medio.ShowDialog();

            }else if(comboBoxModosJogo.Text == "Custom Facil")
            {
                if (!string.IsNullOrEmpty(Program.ID))
                {
                    mapa = new XDocument();
                    sI = new Server();
                    mapa = sI.GetMap(Program.ID, "Facil");
                    Facil facilCustom = new Facil(mapa);
                    facilCustom.getMapaCustomFacil(mapa);
                    this.Hide();
                    facilCustom.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Precisa de efetuar login para jogar online!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }  
            }
            else if (comboBoxModosJogo.Text == "Custom Intermedio")
            {
                if (!string.IsNullOrEmpty(Program.ID))
                {
                    mapa = new XDocument();
                    sI = new Server();
                    mapa = sI.GetMap(Program.ID, "Medio");
                    Intermedio medioCustom = new Intermedio(mapa);
                    this.Hide();
                    medioCustom.ShowDialog();
                   
                }
                else
                {
                    MessageBox.Show("Precisa de efetuar login para jogar online!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }


        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajuda ajuda = new Ajuda();
            ajuda.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registo login = new Registo();
            playMenu.Stop();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void pictureBoxSom_Click(object sender, EventArgs e)
        {
            if(i==0)
            {
                playMenu.Stop();
                pictureBoxSom.Image = Properties.Resources.sound;
                i++;
            }
            else if(i==1)
            {
                playMenu.PlayLooping();
                pictureBoxSom.Image = Properties.Resources.nosound;
                i--;
            }
        }

        private void leaderboardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Leaderboards lead = new Leaderboards();
            lead.ShowDialog();
            
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Program.User = null;
            Program.ID = null;
            labelUserMenu.Text = "Offline";
        }

        private void verPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerPerfis vp = new VerPerfis();
            vp.ShowDialog();
        }

        
    }
    
}
