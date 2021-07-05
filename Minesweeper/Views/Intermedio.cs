using Minesweeper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Minesweeper
{
    public partial class Intermedio : Form
    {
       
        SoundPlayer playMedio = new SoundPlayer(Properties.Resources.musicaMedio);
        private int ticksmedio;
        private int w = 0;
        static Tabuleiro meuTabuleiro;
        public Button[,] btnGridM;
        Stopwatch timerIntermedio = new Stopwatch();
        StreamReader srm = null;
        StreamWriter swm = null;
        Server serverMedio = new Server();
        XDocument custM = new XDocument();
        public int cornotM { get; set; }
        

        public Intermedio()
        {
            cornotM = 0;
            Program.firstClick = true;
            InitializeComponent();
            logadoComoMedio();
            setTabuleiroMedio();
        }

        public Intermedio(XDocument mapa)
        {
            cornotM = 1;
            InitializeComponent();
            logadoComoMedio();
        }

        public void getCustomMapMedio(XDocument custom)
        {
            custM = custom;
        }

        private void logadoComoMedio()
        {
            if (!string.IsNullOrEmpty(Program.User))
            {
                labelUserMedio.Text = Program.User;
            }
            else
            {
                labelUserMedio.Text = "Offline";
            }
        }
        private void setTabuleiroMedio()
        {
            panelMedio.Controls.Clear();
            popularGridMedia();
        }

        private void popularGridMedia()
        {
            int buttonSize = panelMedio.Width / 16;
            panelMedio.Height = 40 * 16;
            panelMedio.Width = 40 * 16;
            meuTabuleiro = new Tabuleiro(16);
            btnGridM = new Button[meuTabuleiro.tamanhoT, meuTabuleiro.tamanhoT];
            meuTabuleiro.colocarMinas();
            meuTabuleiro.calcularVizinhosComMina();

            for (int i = 0; i < meuTabuleiro.tamanhoT; i++)
            {
                for (int j = 0; j < meuTabuleiro.tamanhoT; j++)
                {
                    btnGridM[i, j] = new Button();
                    btnGridM[i, j].Height = buttonSize;
                    btnGridM[i, j].Width = buttonSize;
                    btnGridM[i, j].MouseUp += Intermedio_MouseUp;
                    btnGridM[i, j].MouseDown += Intermedio_MouseDown;
                    panelMedio.Controls.Add(btnGridM[i, j]);
                    btnGridM[i, j].Location = new Point(i * buttonSize, j * buttonSize);
                    btnGridM[i, j].Tag = new Point(i, j);
                }
            }
        }

        private void Intermedio_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxGameButtonMedio.Image = Properties.Resources.Game_Button_Click;
        }

        private void Intermedio_MouseUp(object sender, MouseEventArgs e)
        {
            Button botaoClicado = (Button)sender;
            Point location = (Point)botaoClicado.Tag;
            int x = location.X;
            int y = location.Y;

            if (Program.firstClick == true)
            {
                timerMedio.Stop();
                timerMedio.Start();
                timerIntermedio.Reset();
                timerIntermedio.Start();

                Program.firstClick = false;
            }
            if (e.Button == MouseButtons.Left)
            {
                meuTabuleiro.revelarCelula(x, y);
                redrawBoard();
            }
            if(e.Button == MouseButtons.Right)
            {
                if (Int32.Parse(labelNumMinasMedio.Text) == 0 && meuTabuleiro.Grid[x, y].temFlag == false)
                {

                }
                else
                {
                    meuTabuleiro.colocarFlag(x, y);
                    redrawBoard();
                    if (!meuTabuleiro.Grid[x, y].temFlag)
                    {
                        int kminas;
                        kminas = Int32.Parse(labelNumMinasMedio.Text);
                        kminas++;
                        labelNumMinasMedio.Text = kminas.ToString();
                    }
                    else
                    {
                        int kminas = 0;

                        Int32.TryParse(labelNumMinasMedio.Text, out kminas);
                        kminas--;
                        labelNumMinasMedio.Text = kminas.ToString();
                    }
                }
               
            }
            meuTabuleiro.checkStatus();

            if (meuTabuleiro.won)
            {
                timerIntermedio.Stop();
                timerMedio.Stop();

                srm = new StreamReader("leaderboardsmedio.txt");
                string a = srm.ReadToEnd();
                srm.Close();
                int ficheiro = Convert.ToInt32(a);
                int label = Convert.ToInt32(labelTimeMedio.Text);
                if (label < ficheiro)
                {
                    swm = new StreamWriter("leaderboardsmedio.txt");     
                    swm.WriteLine(labelTimeMedio.Text);
                    swm.Close();
                }

                serverMedio.RegistoJogo("Medio", Convert.ToInt32(labelTimeMedio.Text), "True", Program.ID);

                var resultado = MessageBox.Show("Ganhaste!!! Tempo: " + timerIntermedio.Elapsed.ToString(@"mm\:ss\.ff") + "\nPretende reiniciar ou voltar ao menu?", "Aviso", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                if(resultado == DialogResult.Cancel)
                {
                    this.Hide();
                    playMedio.Stop();
                    Tab iniciomedio = new Tab();
                    iniciomedio.ShowDialog();
                    this.Close();
                }else if (resultado == DialogResult.Retry)
                {
                    this.Hide();
                    Intermedio inter2 = new Intermedio();
                    inter2.ShowDialog();
                    this.Close();
                }
            }
            if (meuTabuleiro.lost)
            {
                timerIntermedio.Stop();
                timerMedio.Stop();
                for(int c = 0; c < meuTabuleiro.tamanhoT; c++)
                {
                    for(int r=0; r<meuTabuleiro.tamanhoT; r++)
                    {
                        if (meuTabuleiro.Grid[r, c].temMina)
                        {
                            meuTabuleiro.Grid[r, c].foiClicado = true;
                        }
                    }
                }
                redrawBoard();
                pictureBoxGameButtonMedio.Image = Properties.Resources.Game_Button_Dead;

                serverMedio.RegistoJogo("Medio", Convert.ToInt32(labelTimeMedio.Text), "False", Program.ID);

                var result = MessageBox.Show("Perdeste! Tempo: " + timerIntermedio.Elapsed.ToString(@"mm\:ss\.ff") + "\nPretende reiniciar ou voltar ao menu?", "Aviso", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Cancel)
                {
                    this.Hide();
                    playMedio.Stop();
                    Tab iniciofacil = new Tab();
                    iniciofacil.ShowDialog();
                    this.Close();
                }
                else if (result == DialogResult.Retry)
                {
                    this.Hide();
                    Intermedio medio2 = new Intermedio();
                    medio2.ShowDialog();
                    this.Close();
                }
            }
        }

        private void redrawBoard()
        {   
            pictureBoxGameButtonMedio.Image = Properties.Resources.Game_Button;
            for (int x = 0; x < meuTabuleiro.tamanhoT; x++)
            {
                for (int y = 0; y < meuTabuleiro.tamanhoT; y++)
                {
                    btnGridM[x, y].BackgroundImageLayout = ImageLayout.Stretch;
                    if (meuTabuleiro.Grid[x, y].temFlag)
                    {
                        btnGridM[x, y].Text = "";
                        btnGridM[x, y].BackgroundImage = Properties.Resources.Flag;
                    }
                    else if (!meuTabuleiro.Grid[x, y].foiClicado)
                    {
                        btnGridM[x, y].BackgroundImage = null;
                        btnGridM[x, y].Text = "";
                    }
                    else if (!meuTabuleiro.Grid[x, y].temMina)
                    {
                        btnGridM[x, y].BackgroundImage = null;
                        btnGridM[x, y].Enabled = false;
                        if (meuTabuleiro.Grid[x, y].numVizinhosBomba == 1)
                        {
                            btnGridM[x, y].BackgroundImage = Properties.Resources._1;
                        }
                        else if (meuTabuleiro.Grid[x, y].numVizinhosBomba == 2)
                        {
                            btnGridM[x, y].BackgroundImage = Properties.Resources._2;
                        }
                        else if (meuTabuleiro.Grid[x, y].numVizinhosBomba == 3)
                        {
                            btnGridM[x, y].BackgroundImage = Properties.Resources._3;
                        }
                        else if (meuTabuleiro.Grid[x, y].numVizinhosBomba == 4)
                        {
                            btnGridM[x, y].BackgroundImage = Properties.Resources._4;
                        }
                        else if (meuTabuleiro.Grid[x, y].numVizinhosBomba == 5)
                        {
                            btnGridM[x, y].BackgroundImage = Properties.Resources._5;
                        }
                        else if (meuTabuleiro.Grid[x, y].numVizinhosBomba == 6)
                        {
                            btnGridM[x, y].BackgroundImage = Properties.Resources._6;
                        }
                        else if (meuTabuleiro.Grid[x, y].numVizinhosBomba == 7)
                        {
                            btnGridM[x, y].BackgroundImage = Properties.Resources._7;
                        }
                        else if (meuTabuleiro.Grid[x, y].numVizinhosBomba == 8)
                        {
                            btnGridM[x, y].BackgroundImage = Properties.Resources._8;
                        }

                    }
                    else if (meuTabuleiro.Grid[x, y].temMina)
                    {
                        btnGridM[x, y].Text = "";
                        btnGridM[x, y].BackgroundImage = Properties.Resources.Mina;

                    }
                }
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Tem a certeza que pretende sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tab iniciomedio = new Tab();
            iniciomedio.ShowDialog();
            this.Close();
            
        }

        private void leaderboardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajuda ajudamedio = new Ajuda();
            ajudamedio.ShowDialog();
            //this.Width = 3; //EXPERIENCIA
        }

        private void timerMedio_Tick(object sender, EventArgs e)
        {
            ticksmedio++;
            labelTimeMedio.Text = ticksmedio.ToString();
        }

        private void pictureBoxGameButtonMedio_Click(object sender, EventArgs e)
        {
            if(cornotM == 0)
            {
                if (MessageBox.Show("Tem a certeza que quer reiniciar o jogo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                   this.Hide();                
                   Intermedio medio2 = new Intermedio(); 
                   medio2.ShowDialog();
                   this.Close();
                }
            }else if(cornotM == 1)
            {
                if (MessageBox.Show("Tem a certeza que quer reiniciar o jogo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Hide();
                    Intermedio medio2 = new Intermedio(custM);
                    medio2.ShowDialog();
                    this.Close();
                }
            }
            
        }

        private void Intermedio_Load(object sender, EventArgs e)
        {
            playMedio.PlayLooping();
        }

        private void pictureBox257_Click(object sender, EventArgs e)
        {
            if(w == 0)
            {
                playMedio.Stop();
                w++;
                pictureBox257.Image = Properties.Resources.sound;
            }else if(w == 1)
            {
                playMedio.Play();
                w--;
                pictureBox257.Image = Properties.Resources.nosound;
            }
        }
    }
}
