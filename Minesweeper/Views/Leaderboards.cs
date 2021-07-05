using Minesweeper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Xml;

namespace Minesweeper
{
    public partial class Leaderboards : Form
    {
        StreamReader sr = null;
        StreamReader srm = null;

        XDocument top10 = null;

        Server server = null;

        public Leaderboards()
        {
            InitializeComponent();
            try
            {
                UpdateLeadOff();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem a certeza que pretende sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if(resultado == DialogResult.Yes)
                    Application.Exit();
        }


        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            server = new Server();
            top10 = server.UpdateLead();
            int i = 0;
            int j = 0;
            int k = 0;
            int l = 0;
            Label[] label = new Label[100] ;
            Label[] labelT = new Label[100];
            Label[] labelfacilN = new Label[100];
            Label[] labelfacilT = new Label[100];

            var nomes = top10.Descendants("jogador").Select(element => element.Attribute("username").Value);

            foreach(var result in nomes)
            {
                label[i] = new Label();
                label[i].Width = panelMedio.Width;
                label[i].Height = panelMedio.Height / 10;
                label[i].Visible = true;
                label[i].Text = result.ToString();
                panelMedio.Controls.Add(label[i]);
                label[i].Location = new Point(160, i * label[i].Height);
                i++;
            }

            var tempos = top10.Descendants("jogador").Select(element => element.Attribute("tempo").Value);

            foreach (var resultT in tempos)
            {
                labelT[j] = new Label();
                labelT[j].Width = panelMedio.Width;
                labelT[j].Height = panelMedio.Height / 10;
                labelT[j].Visible = true;
                labelT[j].Text = resultT.ToString();
                panelMedio.Controls.Add(labelT[j]);
                labelT[j].Location = new Point(30, j * labelT[j].Height);
                j++;
            }


            var nomesF = top10.Descendants("jogador").Select(element => element.Attribute("username").Value);

            foreach (var resultF in nomesF)
            {
                labelfacilN[k] = new Label();
                labelfacilN[k].Width = panelFacil.Width;
                labelfacilN[k].Height = panelFacil.Height / 10;
                labelfacilN[k].Visible = true;
                labelfacilN[k].Text = resultF.ToString();
                panelFacil.Controls.Add(labelfacilN[k]);
                labelfacilN[k].Location = new Point(160, (k * labelfacilN[k].Height) - 250);
                k++;
            }

            var temposF = top10.Descendants("jogador").Select(element => element.Attribute("tempo").Value);

            foreach (var resultFT in temposF)
            {
                labelfacilT[l] = new Label();
                labelfacilT[l].Width = panelFacil.Width;
                labelfacilT[l].Height = panelFacil.Height / 10;
                labelfacilT[l].Visible = true;
                labelfacilT[l].Text = resultFT.ToString();
                panelFacil.Controls.Add(labelfacilT[l]);
                labelfacilT[l].Location = new Point(0, (l * labelfacilT[l].Height) - 250);
                l++;
            }

            /*if(top10.Element("resultado").Element("objeto").Element("top").Element("nivel").Attribute("dificuldade").Value == "Medio")
            {
                foreach (var element in top10.Element("resultado").Element("objeto").Element("top").Element("nivel").DescendantNodes())
                {
                    label[i] = new Label();
                    
                    label[i].Width = panel1.Width;
                    label[i].Height = panel1.Height / 10;
                    label[i].Visible = true;
                    //label[i].Font = new Font(label[i].Font.FontFamily, 6);
                    label[i].Text = element.ToString();

                    panel1.Controls.Add(label[i]);
                    //textBoxTopOnFacil.Text = element.ToString();
                    label[i].Location = new Point(0, i * label[i].Height);
                    label[i].Tag = new Point(0, i * label[i].Height);
                    i++;
                }
            }*/
        }

        private void Leaderboards_Load(object sender, EventArgs e)
        {
            pictureBoxCup.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxCup.BackgroundImage = Properties.Resources.cup;
            pictureBoxTop.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxTop.BackgroundImage = Properties.Resources.top;
        }

        private void UpdateLeadOff()
        {
            sr = new StreamReader("leaderboardsfacil.txt");
            string a = sr.ReadLine();
            textBoxTopFacilLocal.Text = a;
            sr.Close();

            srm = new StreamReader("leaderboardsmedio.txt");
            string b = srm.ReadToEnd();
            textBoxTopMedioLocal.Text = b;
            srm.Close();
        
        }
    }
}
