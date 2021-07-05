using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Minesweeper.Models;
using Minesweeper;
using Windows.UI.Popups;
using Windows.ApplicationModel.Core;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace G41.Minesweeper.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TestarPanel : Page
    {
        static Tabuleiro tabuleiro;
        public Button[,] btnGrid;
        Server server = null;
        private int inc = 0;
        StreamReader srUwpFacil = null;
        StreamWriter swUwpFacil = null;
        DispatcherTimer dt = null;

        public TestarPanel()
        {
            
            this.InitializeComponent();
            App.firstClick = true;
            server = new Server();
            logadoComo();
            setTabuleiro();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void setTabuleiro()
        {
            popularGrid();

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //dt = new DispatcherTimer();
            //dt.Interval = TimeSpan.FromSeconds(1);
            //dt.Tick += Dt_Tick;
            //dt.Start();
            
        }

        private void popularGrid()
        {
            int buttonSize = 100;
            tabuleiro = new Tabuleiro(9);
            btnGrid = new Button[9, 9];
            tabuleiro.colocarMinas();
            tabuleiro.calcularVizinhosComMina();
            for(int j = 0; j < 9; j++)
            {
                btnGrid[0, j] = new Button();
                btnGrid[0, j].Height = 80;
                btnGrid[0, j].Width = buttonSize;
                btnGrid[0,j].BorderBrush = (SolidColorBrush)Resources["BlueColor"];
                btnGrid[0, j].Tapped += TestarPanel_Tapped;
                btnGrid[0, j].RightTapped += TestarPanel_RightTapped;
                coluna1.Children.Add(btnGrid[0, j]);
                btnGrid[0, j].Tag = new Point(0, j);
            }
            for (int j = 0; j < 9; j++)
            {
                btnGrid[1, j] = new Button();
                btnGrid[1, j].Height = 80;
                btnGrid[1, j].Width = buttonSize;
                btnGrid[1, j].BorderBrush = (SolidColorBrush)Resources["BlueColor"];
                btnGrid[1, j].Tapped += TestarPanel_Tapped;
                btnGrid[1, j].RightTapped += TestarPanel_RightTapped;
                coluna2.Children.Add(btnGrid[1, j]);
                btnGrid[1, j].Tag = new Point(1, j);
            }
            for (int j = 0; j < 9; j++)
            {
                btnGrid[2, j] = new Button();
                btnGrid[2, j].Height = 80;
                btnGrid[2, j].Width = buttonSize;
                btnGrid[2, j].BorderBrush = (SolidColorBrush)Resources["BlueColor"];
                btnGrid[2, j].Tapped += TestarPanel_Tapped;
                btnGrid[2, j].RightTapped += TestarPanel_RightTapped;
                coluna3.Children.Add(btnGrid[2, j]);
                btnGrid[2, j].Tag = new Point(2, j);
            }
            for (int j = 0; j < 9; j++)
            {
                btnGrid[3, j] = new Button();
                btnGrid[3, j].Height = 80;
                btnGrid[3, j].Width = buttonSize;
                btnGrid[3, j].BorderBrush = (SolidColorBrush)Resources["BlueColor"];
                btnGrid[3, j].Tapped += TestarPanel_Tapped;
                btnGrid[3, j].RightTapped += TestarPanel_RightTapped;
                coluna4.Children.Add(btnGrid[3, j]);
                btnGrid[3, j].Tag = new Point(3, j);
            }
            for (int j = 0; j < 9; j++)
            {
                btnGrid[4, j] = new Button();
                btnGrid[4, j].Height = 80;
                btnGrid[4, j].Width = buttonSize;
                btnGrid[4, j].BorderBrush = (SolidColorBrush)Resources["BlueColor"];
                btnGrid[4, j].Tapped += TestarPanel_Tapped;
                btnGrid[4, j].RightTapped += TestarPanel_RightTapped;
                coluna5.Children.Add(btnGrid[4, j]);
                btnGrid[4, j].Tag = new Point(4, j);
            }
            for (int j = 0; j < 9; j++)
            {
                btnGrid[5, j] = new Button();
                btnGrid[5, j].Height = 80;
                btnGrid[5, j].Width = buttonSize;
                btnGrid[5, j].BorderBrush = (SolidColorBrush)Resources["BlueColor"];
                btnGrid[5, j].Tapped += TestarPanel_Tapped;
                btnGrid[5, j].RightTapped += TestarPanel_RightTapped;
                coluna6.Children.Add(btnGrid[5, j]);
                btnGrid[5, j].Tag = new Point(5, j);
            }
            for (int j = 0; j < 9; j++)
            {
                btnGrid[6, j] = new Button();
                btnGrid[6, j].Height = 80;
                btnGrid[6, j].Width = buttonSize;
                btnGrid[6, j].BorderBrush = (SolidColorBrush)Resources["BlueColor"];
                btnGrid[6, j].Tapped += TestarPanel_Tapped;
                btnGrid[6, j].RightTapped += TestarPanel_RightTapped;
                coluna7.Children.Add(btnGrid[6, j]);
                btnGrid[6, j].Tag = new Point(6, j);
            }
            for (int j = 0; j < 9; j++)
            {
                btnGrid[7, j] = new Button();
                btnGrid[7, j].Height = 80;
                btnGrid[7, j].Width = buttonSize;
                btnGrid[7, j].BorderBrush = (SolidColorBrush)Resources["BlueColor"];
                btnGrid[7, j].Tapped += TestarPanel_Tapped;
                btnGrid[7, j].RightTapped += TestarPanel_RightTapped;
                coluna8.Children.Add(btnGrid[7, j]);
                btnGrid[7, j].Tag = new Point(7, j);
            }
            for (int j = 0; j < 9; j++)
            {
                btnGrid[8, j] = new Button();
                btnGrid[8, j].Height = 80;
                btnGrid[8, j].Width = buttonSize;
                btnGrid[8, j].BorderBrush = (SolidColorBrush)Resources["BlueColor"];
                btnGrid[8, j].Tapped += TestarPanel_Tapped;
                btnGrid[8, j].RightTapped += TestarPanel_RightTapped;
                coluna9.Children.Add(btnGrid[8, j]);
                btnGrid[8, j].Tag = new Point(8, j);
            }
        }

        private async void TestarPanel_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            Button botaoclicado = (Button)sender;
            Point location = (Point)botaoclicado.Tag;
            int x = (int)location.X;
            int y = (int)location.Y;

            if(Int32.Parse(textBlockNumMinasFacil.Text) == 0 && tabuleiro.Grid[x,y].temFlag == false)
            {

            }
            else
            {
                tabuleiro.colocarFlag(x, y);
                redrawBoard();

                if (!tabuleiro.Grid[x, y].temFlag)
                {
                    int kminas;
                    kminas = Int32.Parse(textBlockNumMinasFacil.Text);
                    kminas++;
                    textBlockNumMinasFacil.Text = kminas.ToString();
                }
                else
                {
                    int kminas = 0;

                    Int32.TryParse(textBlockNumMinasFacil.Text, out kminas);
                    kminas--;
                    textBlockNumMinasFacil.Text = kminas.ToString();
                }
            }

            

            tabuleiro.checkStatus();
            if (tabuleiro.won)
            {
                dt.Stop();
                string registo = server.RegistoJogo("Facil", Convert.ToInt32(textBlockTimer.Text), "True", App.ID);
                /*srUwpFacil = new StreamReader("leaderboardsuwpfacil.txt");
                string a = srUwpFacil.ReadToEnd();
                srUwpFacil.Close();
                int ficheiro = Convert.ToInt32(a);
                int label = Convert.ToInt32(textBlockTimer.Text);
                if (label < ficheiro)
                {
                    swUwpFacil = new StreamWriter("leaderboardsuwpfacil.txt");
                    //sw.WriteLine(timer.Elapsed.ToString(@"mm\:ss") + " s");
                    swUwpFacil.WriteLine(textBlockTimer.Text);
                    swUwpFacil.Close();
                }*/

                var result = new MessageDialog("Ganhou o jogo!");
                await result.ShowAsync();
                this.Frame.Navigate(typeof(MainPage));
            }
            if (tabuleiro.lost)
            {
                for (int c = 0; c < tabuleiro.tamanhoT; c++)
                {
                    for (int r = 0; r < tabuleiro.tamanhoT; r++)
                    {
                        if (tabuleiro.Grid[r, c].temMina)
                        {
                            tabuleiro.Grid[r, c].foiClicado = true;
                        }
                    }
                }
                redrawBoard();
                string registo = server.RegistoJogo("Facil",Convert.ToInt32(textBlockTimer.Text), "False", App.ID);
                var result2 = new MessageDialog("Perdeu o jogo!");
                await result2.ShowAsync();
                this.Frame.Navigate(typeof(MainPage));

            }
        }

        private async void TestarPanel_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Button botaoclicado = (Button)sender;
            Point location = (Point)botaoclicado.Tag;
            int x = (int)location.X;
            int y = (int)location.Y;

            if(App.firstClick == true)
            {
                dt = new DispatcherTimer();
                dt.Interval = TimeSpan.FromSeconds(1);
                dt.Tick += Dt_Tick;
                dt.Start();
                App.firstClick = false;
            }

            tabuleiro.revelarCelula(x, y);
            redrawBoard();
            tabuleiro.checkStatus();
            if (tabuleiro.won)
            {
                dt.Stop();

                //srUwpFacil = new StreamReader("leaderboardsuwpfacil.txt");
                //string a = srUwpFacil.ReadToEnd();
                //srUwpFacil.Close();
                //int ficheiro = Convert.ToInt32(a);
                //int label = Convert.ToInt32(textBlockTimer.Text);
                //if (label < ficheiro)
                //{
                //    swUwpFacil = new StreamWriter("leaderboardsuwpfacil.txt");
                //    //sw.WriteLine(timer.Elapsed.ToString(@"mm\:ss") + " s");
                //    swUwpFacil.WriteLine(textBlockTimer.Text);
                //    swUwpFacil.Close();
                //}

                server.RegistoJogo("Facil", Convert.ToInt32(textBlockTimer.Text), "True", App.ID);

                var result = new MessageDialog("Ganhou o jogo!");
                await result.ShowAsync();
                this.Frame.Navigate(typeof(MainPage));
            }
            if (tabuleiro.lost)
            {
                for (int c = 0; c < tabuleiro.tamanhoT; c++)
                {
                    for (int r = 0; r < tabuleiro.tamanhoT; r++)
                    {
                        if (tabuleiro.Grid[r, c].temMina)
                        {
                            tabuleiro.Grid[r, c].foiClicado = true;
                        }
                    }
                }
                redrawBoard();
                string registo = server.RegistoJogo("Facil", Convert.ToInt32(textBlockTimer.Text), "False", App.ID);
                var result2 = new MessageDialog("Perdeu o jogo!");
                await result2.ShowAsync();
                this.Frame.Navigate(typeof(MainPage));

            }
        }
        
        private void redrawBoard()
        {
            Image image = null;

            for (int x = 0; x < tabuleiro.tamanhoT; x++)
            {
                for (int y = 0; y < tabuleiro.tamanhoT; y++)
                {
                    if (tabuleiro.Grid[x, y].temFlag)
                    {
                        image = new Image();
                        image.Source = new BitmapImage(new Uri("ms-appx:///Assets/Flag.png"));
                        btnGrid[x, y].Content = image;
                        //btnGrid[x, y].Content = "F";
                    }
                    else if (!tabuleiro.Grid[x, y].foiClicado)
                    {
                        btnGrid[x, y].Content = null;
                        
                    }
                    else if (!tabuleiro.Grid[x, y].temMina)
                    {
                        btnGrid[x, y].Content = null;
                        btnGrid[x, y].IsEnabled = false;
                        btnGrid[x, y].BorderBrush = (SolidColorBrush)Resources["BlueColor"];

                        if (tabuleiro.Grid[x,y].numVizinhosBomba == 0)
                        {
                            btnGrid[x, y].Opacity = 0.5;
                        }


                        if (tabuleiro.Grid[x, y].numVizinhosBomba == 1)
                        {
                            image = new Image();
                            image.Source = new BitmapImage(new Uri("ms-appx:///Assets/1.png"));
                            btnGrid[x, y].Content = image;
                            btnGrid[x, y].BorderBrush = (SolidColorBrush)Resources["BlueColor"];
                        }
                        else if (tabuleiro.Grid[x, y].numVizinhosBomba == 2)
                        {
                            image = new Image();
                            image.Source = new BitmapImage(new Uri("ms-appx:///Assets/2.png"));
                            btnGrid[x, y].Content = image;
                        }
                        else if (tabuleiro.Grid[x, y].numVizinhosBomba == 3)
                        {
                            image = new Image();
                            image.Source = new BitmapImage(new Uri("ms-appx:///Assets/3.png"));
                            btnGrid[x, y].Content = image;
                        }
                        else if (tabuleiro.Grid[x, y].numVizinhosBomba == 4)
                        {
                            image = new Image();
                            image.Source = new BitmapImage(new Uri("ms-appx:///Assets/4.png"));
                            btnGrid[x, y].Content = image;
                        }
                        else if (tabuleiro.Grid[x, y].numVizinhosBomba == 5)
                        {
                            image = new Image();
                            image.Source = new BitmapImage(new Uri("ms-appx:///Assets/5.png"));
                            btnGrid[x, y].Content = image;
                        }
                        else if (tabuleiro.Grid[x, y].numVizinhosBomba == 6)
                        {
                            image = new Image();
                            image.Source = new BitmapImage(new Uri("ms-appx:///Assets/6.png"));
                            btnGrid[x, y].Content = image;
                        }
                        else if (tabuleiro.Grid[x, y].numVizinhosBomba == 7)
                        {
                            image = new Image();
                            image.Source = new BitmapImage(new Uri("ms-appx:///Assets/7.png"));
                            btnGrid[x, y].Content = image;
                        }
                        else if (tabuleiro.Grid[x, y].numVizinhosBomba == 8)
                        {
                            image = new Image();
                            image.Source = new BitmapImage(new Uri("ms-appx:///Assets/8.png"));
                            btnGrid[x, y].Content = image;
                        }

                    }
                    else if (tabuleiro.Grid[x, y].temMina)
                    {
                        image = new Image();
                        image.Source = new BitmapImage(new Uri("ms-appx:///Assets/Mina.png"));
                        btnGrid[x, y].Content = image;
                    }
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CoreApplication.Exit();
        }

        private void gameButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(TestarPanel));
        }

        

        private void Dt_Tick(object sender, object e)
        {
            inc++;
            textBlockTimer.Text = inc.ToString();
            
        }

        private void logadoComo()
        {
            if (!string.IsNullOrEmpty(App.ID)){
                textBlockUserFacil.Text = App.username;
            }
            else
            {
                textBlockUserFacil.Text = "Offline";
            }
        }
    }
}
