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
using System.Media;
using System.Globalization;
using Minesweeper.Models;
using System.IO;
using System.Xml.Linq;

namespace Minesweeper
{
    
    public partial class Facil : Form
    {
        
        private int ticksfacil;
        SoundPlayer play = new SoundPlayer(Properties.Resources.musicaFacil);
        int w = 0;
        static Tabuleiro meuTabuleiro;
        public Button[,] btnGrid;
        Stopwatch timer = new Stopwatch();
        Server server = new Server();
        StreamWriter sw = null;
        StreamReader sr = null;
        XDocument cust = new XDocument();
        public static int cornot { get; set; }

        public Facil()
        {
            cornot = 0;
            Program.firstClick = true;
            InitializeComponent();
            logadoComo();
            setTabuleiro();
            
        }

        public Facil(XDocument custom)
        {
            cornot = 1;
            InitializeComponent();
            logadoComo();
        }

        public void getMapaCustomFacil(XDocument custom)
        {
            cust = custom;
        }

        private void setTabuleiro()
        {
            panelFacil.Controls.Clear();
            popularGrid();
            //timerFacil.Stop();
            //timerFacil.Start();
            //timer.Reset();
            //timer.Start();
        }

        private void logadoComo()
        {

            if (!String.IsNullOrEmpty(Program.User))
            {
                
                labelUserFF.Text = Program.User;
            }
            else
            {
                labelUserFF.Text = "Offline";
            }
        }
        
        private void popularGrid()
        {
            int buttonSize = panelFacil.Width / 9;
            panelFacil.Height = 40 * 9;
            panelFacil.Width = 40 * 9;
            meuTabuleiro = new Tabuleiro(9);
            btnGrid = new Button[meuTabuleiro.tamanhoT, meuTabuleiro.tamanhoT];
            meuTabuleiro.colocarMinas();
            meuTabuleiro.calcularVizinhosComMina();

            for (int i = 0; i < meuTabuleiro.tamanhoT; i++)
            {
                for (int j = 0; j < meuTabuleiro.tamanhoT; j++)
                {
                    btnGrid[i, j] = new Button();
                    btnGrid[i, j].Height = buttonSize;
                    btnGrid[i, j].Width = buttonSize;
                    btnGrid[i, j].MouseUp += Facil_MouseUp;
                    btnGrid[i, j].MouseDown += Facil_MouseDown;
                    panelFacil.Controls.Add(btnGrid[i, j]);
                    btnGrid[i, j].Location = new Point(i * buttonSize, j * buttonSize);
                    btnGrid[i, j].Tag = new Point(i, j);
                }
            }
        }

        private void Facil_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxGameButton.Image = Properties.Resources.Game_Button_Click;
        }

        private void Facil_MouseUp(object sender, MouseEventArgs e)
        {
            Button botaoClicado = (Button)sender; //o sender diz nos que botao foi clicado
            Point location = (Point)botaoClicado.Tag;
            int x = location.X;
            int y = location.Y;

            if(Program.firstClick == true)
            {
                timerFacil.Stop();
                timerFacil.Start();
                timer.Reset();
                timer.Start();
                Program.firstClick = false;
            }

            if (e.Button == MouseButtons.Left)
            {
                    meuTabuleiro.revelarCelula(x, y);
                    redrawBoard();
            }
            if (e.Button == MouseButtons.Right)
            {
                if (Int32.Parse(labelNumMinasFacil.Text) == 0 && meuTabuleiro.Grid[x,y].temFlag ==false)
                {

                }
                else
                {

                    meuTabuleiro.colocarFlag(x, y);
                    redrawBoard();
                    if (!meuTabuleiro.Grid[x, y].temFlag)
                    {
                        int kminas;
                        kminas = Int32.Parse(labelNumMinasFacil.Text);
                        kminas++;
                        labelNumMinasFacil.Text = kminas.ToString();
                    }
                    else
                    {
                        int kminas = 0;

                        Int32.TryParse(labelNumMinasFacil.Text, out kminas);
                        kminas--;
                        labelNumMinasFacil.Text = kminas.ToString();
                    }
                }
            }
            meuTabuleiro.checkStatus();

            if (meuTabuleiro.won)
            {
                timer.Stop();
                timerFacil.Stop();

                server.RegistoJogo("Facil", Convert.ToInt32(labelTimerFacil.Text), "True", Program.ID);
              
                sr = new StreamReader("leaderboardsfacil.txt");
                string a = sr.ReadToEnd();
                sr.Close();
                int ficheiro = Convert.ToInt32(a);
                int label = Convert.ToInt32(labelTimerFacil.Text);
                if (label < ficheiro)
                {
                    sw = new StreamWriter("leaderboardsfacil.txt");
                    sw.WriteLine(labelTimerFacil.Text);
                    sw.Close();
                }
                
                var result = MessageBox.Show("Ganhaste!!! Tempo: " + timer.Elapsed.ToString(@"mm\:ss\.ff") + "\nPretende reiniciar ou voltar ao menu?", "Aviso", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Cancel)
                {
                    this.Hide();
                    play.Stop();
                    Tab iniciofacil = new Tab();
                    iniciofacil.ShowDialog();
                    this.Close();
                }
                else if (result == DialogResult.Retry)
                {
                    this.Hide();
                    Facil facil2 = new Facil();
                    facil2.ShowDialog();
                    this.Close();
                }

            }
            if (meuTabuleiro.lost)
            {
                timer.Stop();
                timerFacil.Stop();
                for (int c = 0; c < meuTabuleiro.tamanhoT; c++)
                {
                    for (int r = 0; r < meuTabuleiro.tamanhoT; r++)
                    {
                        if (meuTabuleiro.Grid[r, c].temMina)
                        {
                            meuTabuleiro.Grid[r, c].foiClicado = true;
                        }
                    }
                }
                redrawBoard();
                pictureBoxGameButton.Image = Properties.Resources.Game_Button_Dead;

                server.RegistoJogo("Facil", Convert.ToInt32(labelTimerFacil.Text), "False", Program.ID);
                
                var result = MessageBox.Show("Perdeste! Tempo: "+ timer.Elapsed.ToString(@"mm\:ss\.ff") +"\nPretende reiniciar ou voltar ao menu?", "Aviso", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Cancel)
                {
                    this.Hide();
                    play.Stop();
                    Tab iniciofacil = new Tab();
                    iniciofacil.ShowDialog();
                    this.Close();
                }else if(result == DialogResult.Retry)
                {
                    this.Hide();               
                    Facil facil2 = new Facil();
                    facil2.ShowDialog();
                    this.Close();
                }
                    

            }
        }

        private void redrawBoard()
        {
            pictureBoxGameButton.Image = Properties.Resources.Game_Button;
            for (int x = 0; x < meuTabuleiro.tamanhoT; x++)
            {
                for (int y = 0; y < meuTabuleiro.tamanhoT; y++)
                {
                    btnGrid[x, y].BackgroundImageLayout = ImageLayout.Stretch;

                    if (meuTabuleiro.Grid[x, y].temFlag)
                    {
                        btnGrid[x, y].BackgroundImage = Properties.Resources.Flag;
                    }
                    else if (!meuTabuleiro.Grid[x, y].foiClicado)
                    {
                        btnGrid[x, y].BackgroundImage = null;
                    }
                    else if (!meuTabuleiro.Grid[x, y].temMina)
                    {
                        btnGrid[x, y].BackgroundImage = null;
                        btnGrid[x, y].Enabled = false;
                        
                        if(meuTabuleiro.Grid[x,y].numVizinhosBomba == 1)
                        {
                            btnGrid[x, y].BackgroundImage = Properties.Resources._1;

                        }else if(meuTabuleiro.Grid[x, y].numVizinhosBomba == 2)
                        {
                            btnGrid[x, y].BackgroundImage = Properties.Resources._2;
                        }
                        else if (meuTabuleiro.Grid[x, y].numVizinhosBomba == 3)
                        {
                            btnGrid[x, y].BackgroundImage = Properties.Resources._3;
                        }
                        else if (meuTabuleiro.Grid[x, y].numVizinhosBomba == 4)
                        {
                            btnGrid[x, y].BackgroundImage = Properties.Resources._4;
                        }
                        else if (meuTabuleiro.Grid[x, y].numVizinhosBomba == 5)
                        {
                            btnGrid[x, y].BackgroundImage = Properties.Resources._5;
                        }
                        else if (meuTabuleiro.Grid[x, y].numVizinhosBomba == 6)
                        {
                            btnGrid[x, y].BackgroundImage = Properties.Resources._6;
                        }
                        else if (meuTabuleiro.Grid[x, y].numVizinhosBomba == 7)
                        {
                            btnGrid[x, y].BackgroundImage = Properties.Resources._7;
                        }
                        else if (meuTabuleiro.Grid[x, y].numVizinhosBomba == 8)
                        {
                            btnGrid[x, y].BackgroundImage = Properties.Resources._8;
                        }

                    }
                    else if (meuTabuleiro.Grid[x, y].temMina)
                    {
                        btnGrid[x, y].BackgroundImage = Properties.Resources.Mina;

                    }
                }
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Tem a certeza que pretende sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
                
            
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            play.Stop();
            Tab iniciofacil = new Tab();
            iniciofacil.ShowDialog();
            this.Close();
        }

        private void pictureBoxGameButton_Click_1(object sender, EventArgs e)
        {
            if (cornot == 0)
            {

            
                if (MessageBox.Show("Tem a certeza que quer reiniciar o jogo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {


                this.Hide();                //Esconder o formulario 1
                Facil facil2 = new Facil(); //Mostrar o formulario 2
                facil2.ShowDialog();
                this.Close();               //Fechar o formulario 1

                /*this.Hide();
                var facil2 = new Facil();
                facil2.Closed += (s, args) => this.Close();
                facil2.ShowDialog();*/
                }
            }else if(cornot == 1)
            {
                if (MessageBox.Show("Tem a certeza que quer reiniciar o jogo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {


                    this.Hide();                
                    Facil facil2 = new Facil(cust); 
                    facil2.ShowDialog();
                    this.Close();               

                }
            }
        }

       

        private void leaderboardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajuda ajudafacil = new Ajuda();
            ajudafacil.ShowDialog();
        }

        private void timerFacil_Tick(object sender, EventArgs e)
        {
            ticksfacil++;
            labelTimerFacil.Text = ticksfacil.ToString();
        }

        private void Facil_Load(object sender, EventArgs e)
        {
            play.PlayLooping();
        }

     

        private void pictureBoxSound_Click(object sender, EventArgs e)
        {
            if (w == 0)
            {
                pictureBoxSound.Image = Properties.Resources.sound;
                w++;
                play.Stop();
            }
            else if (w == 1)
            {
                pictureBoxSound.Image = Properties.Resources.nosound;
                w--;
                play.Play();
            }
        }

        private void Facil_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
