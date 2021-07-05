using Minesweeper.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace G41.Minesweeper.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Leaderboards : Page
    {
        Server serverLead = new Server();
        XDocument lead = new XDocument();
        public Leaderboards()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lead = serverLead.UpdateLead();

            int i = 0;
            int j = 0;
            TextBlock[] label = new TextBlock[100];
            TextBlock[] labelT = new TextBlock[100];

            var nomes = lead.Descendants("jogador").Select(element => element.Attribute("username").Value);

            foreach (var result in nomes)
            {
                if (i == 0)
                {
                    label[i] = new TextBlock();
                    label[i].Width = stackPanelMedio.Width;
                    label[i].Height = stackPanelMedio.Height / 10;
                    label[i].Text = "Medio:" + result.ToString();
                    stackPanelMedio.Children.Add(label[i]);

                }
                else if(i == 10)
                {
                    label[i] = new TextBlock();
                    label[i].Width = stackPanelMedio.Width;
                    label[i].Height = stackPanelMedio.Height / 10;
                    label[i].Text = "Facil:  " + result.ToString();
                   stackPanelMedio.Children.Add(label[i]);

                }
                else
                {
                    label[i] = new TextBlock();
                    label[i].Width = stackPanelMedio.Width;
                    label[i].Height = stackPanelMedio.Height / 10;
                    label[i].Text = "          " + result.ToString();
                    stackPanelMedio.Children.Add(label[i]);
                }
                
                i++;
            }
            int k = 0;
            var tempos = lead.Descendants("jogador").Select(element => element.Attribute("tempo").Value);

            foreach (var result in tempos)
            {
               
                    label[k] = new TextBlock();
                    label[k].Width = stackPanelMedio.Width;
                    label[k].Height = stackPanelMedio.Height / 10;
                    label[k].Text = result.ToString();
                    stackPanelFacil.Children.Add(label[k]);

                k++;
            }
        }
    }
}
