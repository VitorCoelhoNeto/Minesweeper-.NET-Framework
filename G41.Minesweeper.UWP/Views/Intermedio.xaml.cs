using Minesweeper;
using Minesweeper.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace G41.Minesweeper.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Intermedio : Page
    {
        DispatcherTimer dtm = null;
        int incm = 0;
        static Tabuleiro tabuleiro;
        public Button[,] btnGrid;
        Server serverMedio = null;
        
        public Intermedio()
        {
            this.InitializeComponent();
            App.firstClick = true;
            serverMedio = new Server();
            logadoComo();
            setTabuleiro();
        }

        private void setTabuleiro()
        {
            popularGrid();
        }
        private void popularGrid()
        {
            int buttonwidth = 55;
            int buttonheight = 45;
            tabuleiro = new Tabuleiro(16);
            btnGrid = new Button[16, 16];
            tabuleiro.colocarMinas();
            tabuleiro.calcularVizinhosComMina();
            for(int j=0; j<16; j++)
            {
                btnGrid[0, j] = new Button();
                btnGrid[0, j].Height = buttonheight;
                btnGrid[0, j].Width = buttonwidth;
                btnGrid[0, j].BorderBrush = (SolidColorBrush)Resources["BlueColor"];
                btnGrid[0, j].Tapped += Intermedio_Tapped;
                btnGrid[0, j].RightTapped += Intermedio_RightTapped;
                coluna1.Children.Add(btnGrid[0, j]);
                btnGrid[0, j].Tag = new Point(0, j);
            }
            for (int j = 0; j < 16; j++)
            {
                btnGrid[1, j] = new Button();
                btnGrid[1, j].Height = buttonheight;
                btnGrid[1, j].Width = buttonwidth;
                btnGrid[1, j].BorderBrush = (SolidColorBrush)Resources["BlueColor"];
                btnGrid[1, j].Tapped += Intermedio_Tapped;
                btnGrid[1, j].RightTapped += Intermedio_RightTapped;
                coluna2.Children.Add(btnGrid[1, j]);
                btnGrid[1, j].Tag = new Point(1, j);
            }
            for (int j = 0; j < 16; j++)
            {
                btnGrid[2, j] = new Button();
                btnGrid[2, j].Height = buttonheight;
                btnGrid[2, j].Width = buttonwidth;
                btnGrid[2, j].BorderBrush = (SolidColorBrush)Resources["BlueColor"];
                btnGrid[2, j].Tapped += Intermedio_Tapped;
                btnGrid[2, j].RightTapped += Intermedio_RightTapped;
                coluna3.Children.Add(btnGrid[2, j]);
                btnGrid[2, j].Tag = new Point(2, j);
            }
            for (int j = 0; j < 16; j++)
            {
                btnGrid[3, j] = new Button();
                btnGrid[3, j].Height = buttonheight;
                btnGrid[3, j].Width = buttonwidth;
                btnGrid[3, j].BorderBrush = (SolidColorBrush)Resources["BlueColor"];
                btnGrid[3, j].Tapped += Intermedio_Tapped;
                btnGrid[3, j].RightTapped += Intermedio_RightTapped;
                coluna4.Children.Add(btnGrid[3, j]);
                btnGrid[3, j].Tag = new Point(3, j);
            }
            for (int j = 0; j < 16; j++)
            {
                btnGrid[4, j] = new Button();
                btnGrid[4, j].Height = buttonheight;
                btnGrid[4, j].Width = buttonwidth;
                btnGrid[4, j].BorderBrush = (SolidColorBrush)Resources["BlueColor"];
                btnGrid[4, j].Tapped += Intermedio_Tapped;
                btnGrid[4, j].RightTapped += Intermedio_RightTapped;
                coluna5.Children.Add(btnGrid[4, j]);
                btnGrid[4, j].Tag = new Point(4, j);
            }
            for (int j = 0; j < 16; j++)
            {
                btnGrid[5, j] = new Button();
                btnGrid[5, j].Height = buttonheight;
                btnGrid[5, j].Width = buttonwidth;
                btnGrid[5, j].BorderBrush = (SolidColorBrush)Resources["BlueColor"];
                btnGrid[5, j].Tapped += Intermedio_Tapped;
                btnGrid[5, j].RightTapped += Intermedio_RightTapped;
                coluna6.Children.Add(btnGrid[5, j]);
                btnGrid[5, j].Tag = new Point(5, j);
            }
            for (int j = 0; j < 16; j++)
            {
                btnGrid[6, j] = new Button();
                btnGrid[6, j].Height = buttonheight;
                btnGrid[6, j].Width = buttonwidth;
                btnGrid[6, j].BorderBrush = (SolidColorBrush)Resources["BlueColor"];
                btnGrid[6, j].Tapped += Intermedio_Tapped;
                btnGrid[6, j].RightTapped += Intermedio_RightTapped;
                coluna7.Children.Add(btnGrid[6, j]);
                btnGrid[6, j].Tag = new Point(6, j);
            }
            for (int j = 0; j < 16; j++)
            {
                btnGrid[7, j] = new Button();
                btnGrid[7, j].Height = buttonheight;
                btnGrid[7, j].Width = buttonwidth;
                btnGrid[7, j].BorderBrush = (SolidColorBrush)Resources["BlueColor"];
                btnGrid[7, j].Tapped += Intermedio_Tapped;
                btnGrid[7, j].RightTapped += Intermedio_RightTapped;
                coluna8.Children.Add(btnGrid[7, j]);
                btnGrid[7, j].Tag = new Point(7, j);
            }
            for (int j = 0; j < 16; j++)
            {
                btnGrid[8, j] = new Button();
                btnGrid[8, j].Height = buttonheight;
                btnGrid[8, j].Width = buttonwidth;
                btnGrid[8, j].BorderBrush = (SolidColorBrush)Resources["BlueColor"];
                btnGrid[8, j].Tapped += Intermedio_Tapped;
                btnGrid[8, j].RightTapped += Intermedio_RightTapped;
                coluna9.Children.Add(btnGrid[8, j]);
                btnGrid[8, j].Tag = new Point(8, j);
            }
            for (int j = 0; j < 16; j++)
            {
                btnGrid[9, j] = new Button();
                btnGrid[9, j].Height = buttonheight;
                btnGrid[9, j].Width = buttonwidth;
                btnGrid[9, j].BorderBrush = (SolidColorBrush)Resources["BlueColor"];
                btnGrid[9, j].Tapped += Intermedio_Tapped;
                btnGrid[9, j].RightTapped += Intermedio_RightTapped;
                coluna10.Children.Add(btnGrid[9, j]);
                btnGrid[9, j].Tag = new Point(9, j);
            }
            for (int j = 0; j < 16; j++)
            {
                btnGrid[10, j] = new Button();
                btnGrid[10, j].Height = buttonheight;
                btnGrid[10, j].Width = buttonwidth;
                btnGrid[10, j].BorderBrush = (SolidColorBrush)Resources["BlueColor"];
                btnGrid[10, j].Tapped += Intermedio_Tapped;
                btnGrid[10, j].RightTapped += Intermedio_RightTapped;
                coluna11.Children.Add(btnGrid[10, j]);
                btnGrid[10, j].Tag = new Point(10, j);
            }
            for (int j = 0; j < 16; j++)
            {
                btnGrid[11, j] = new Button();
                btnGrid[11, j].Height = buttonheight;
                btnGrid[11, j].Width = buttonwidth;
                btnGrid[11, j].BorderBrush = (SolidColorBrush)Resources["BlueColor"];
                btnGrid[11, j].Tapped += Intermedio_Tapped;
                btnGrid[11, j].RightTapped += Intermedio_RightTapped;
                coluna12.Children.Add(btnGrid[11, j]);
                btnGrid[11, j].Tag = new Point(11, j);
            }
            for (int j = 0; j < 16; j++)
            {
                btnGrid[12, j] = new Button();
                btnGrid[12, j].Height = buttonheight;
                btnGrid[12, j].Width = buttonwidth;
                btnGrid[12, j].BorderBrush = (SolidColorBrush)Resources["BlueColor"];
                btnGrid[12, j].Tapped += Intermedio_Tapped;
                btnGrid[12, j].RightTapped += Intermedio_RightTapped;
                coluna13.Children.Add(btnGrid[12, j]);
                btnGrid[12, j].Tag = new Point(12, j);
            }
            for (int j = 0; j < 16; j++)
            {
                btnGrid[13, j] = new Button();
                btnGrid[13, j].Height = buttonheight;
                btnGrid[13, j].Width = buttonwidth;
                btnGrid[13, j].BorderBrush = (SolidColorBrush)Resources["BlueColor"];
                btnGrid[13, j].Tapped += Intermedio_Tapped;
                btnGrid[13, j].RightTapped += Intermedio_RightTapped;
                coluna14.Children.Add(btnGrid[13, j]);
                btnGrid[13, j].Tag = new Point(13, j);
            }
            for (int j = 0; j < 16; j++)
            {
                btnGrid[14, j] = new Button();
                btnGrid[14, j].Height = buttonheight;
                btnGrid[14, j].Width = buttonwidth;
                btnGrid[14, j].BorderBrush = (SolidColorBrush)Resources["BlueColor"];
                btnGrid[14, j].Tapped += Intermedio_Tapped;
                btnGrid[14, j].RightTapped += Intermedio_RightTapped;
                coluna15.Children.Add(btnGrid[14, j]);
                btnGrid[14, j].Tag = new Point(14, j);
            }
            for (int j = 0; j < 16; j++)
            {
                btnGrid[15, j] = new Button();
                btnGrid[15, j].Height = buttonheight;
                btnGrid[15, j].Width = buttonwidth;
                btnGrid[15, j].BorderBrush = (SolidColorBrush)Resources["BlueColor"];
                btnGrid[15, j].Tapped += Intermedio_Tapped;
                btnGrid[15, j].RightTapped += Intermedio_RightTapped;
                coluna16.Children.Add(btnGrid[15, j]);
                btnGrid[15, j].Tag = new Point(15, j);
            }
        }

        private async void Intermedio_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            Button botaoclicado = (Button)sender;
            Point location = (Point)botaoclicado.Tag;
            int x = (int)location.X;
            int y = (int)location.Y;

            if (Int32.Parse(textBlockNumMinasMedio.Text) == 0 && tabuleiro.Grid[x, y].temFlag == false)
            {

            }
            else
            {
                tabuleiro.colocarFlag(x, y);
                redrawBoard();

                if (!tabuleiro.Grid[x, y].temFlag)
                {
                    int kminas;
                    kminas = Int32.Parse(textBlockNumMinasMedio.Text);
                    kminas++;
                    textBlockNumMinasMedio.Text = kminas.ToString();
                }
                else
                {
                    int kminas = 0;

                    Int32.TryParse(textBlockNumMinasMedio.Text, out kminas);
                    kminas--;
                    textBlockNumMinasMedio.Text = kminas.ToString();
                }
            }



            tabuleiro.checkStatus();
            if (tabuleiro.won)
            {
                dtm.Stop();

                serverMedio.RegistoJogo("Facil", Convert.ToInt32(textBlockTimerMedio.Text), "True", App.ID);
             

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
                string registo = serverMedio.RegistoJogo("Facil", Convert.ToInt32(textBlockTimerMedio.Text), "False", App.ID);
                var result2 = new MessageDialog("Perdeu o jogo!");
                await result2.ShowAsync();
                this.Frame.Navigate(typeof(MainPage));

            }
        }

        private async void Intermedio_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Button botaoclicado = (Button)sender;
            Point location = (Point)botaoclicado.Tag;
            int x = (int)location.X;
            int y = (int)location.Y;

            if (App.firstClick == true)
            {
                dtm = new DispatcherTimer();
                dtm.Interval = TimeSpan.FromSeconds(1);
                dtm.Tick += Dtm_Tick;
                dtm.Start();
                App.firstClick = false;
            }

            tabuleiro.revelarCelula(x, y);
            redrawBoard();
            tabuleiro.checkStatus();
            if (tabuleiro.won)
            {
                dtm.Stop();

                string registo = serverMedio.RegistoJogo("Facil", Convert.ToInt32(textBlockTimerMedio.Text), "True", App.ID);
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
                serverMedio.RegistoJogo("Facil", Convert.ToInt32(textBlockTimerMedio.Text), "False", App.ID);
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
                        if (tabuleiro.Grid[x, y].numVizinhosBomba == 0)
                        {
                            btnGrid[x, y].Opacity = 0.5;
                        }

                        if (tabuleiro.Grid[x, y].numVizinhosBomba == 1)
                        {
                            image = new Image();
                            image.Source = new BitmapImage(new Uri("ms-appx:///Assets/1.png"));
                            btnGrid[x, y].Content = image;
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

        private void buttonMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CoreApplication.Exit();
        }

        private void buttonGameButtonMedio_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Intermedio));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
        private void logadoComo()
        {
            if (!string.IsNullOrEmpty(App.ID))
            {
                textBlockUserMedio.Text = App.username;
            }
            else
            {
                textBlockUserMedio.Text = "Offline";
            }
        }
        private void Dtm_Tick(object sender, object e)
        {
            incm++;
            textBlockTimerMedio.Text = incm.ToString();
        }
    }
}
