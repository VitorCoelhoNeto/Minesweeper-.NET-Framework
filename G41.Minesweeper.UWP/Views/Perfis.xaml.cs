using Minesweeper.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Transactions;
using System.Xml.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Imaging;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;
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
    public sealed partial class Perfis : Page
    {
        XDocument resposta = null;
        Server servidorPerfil = null;
        Image image = null;

        public Perfis()
        {
            this.InitializeComponent();
            logadoComo();
        }

        private void buttonMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void logadoComo()
        {
            if (!string.IsNullOrEmpty(App.username))
            {
                textBlockUserPerfis.Text = App.username;
            }
            else
            {
                textBlockUserPerfis.Text = "Offline";
            }
        }

        private async void buttonPesquisar_Click(object sender, RoutedEventArgs e)
        {
            servidorPerfil = new Server();
            resposta = new XDocument();
            resposta = servidorPerfil.GetPerfil(textBoxPerfil.Text);


            try
            {
                string status = resposta.Element("resultado").Element("status").Value;
                string contexto = resposta.Element("resultado").Element("contexto").Value;
                if (status == "ERRO")
                {
                    var result = new MessageDialog(contexto);
                    await result.ShowAsync();
                }
                else
                {
                    textBlockNomeAbr.Text = resposta.Element("resultado").Element("objeto").Element("perfil").Element("nomeabreviado").Value;
                    textBlockEmail.Text = resposta.Element("resultado").Element("objeto").Element("perfil").Element("email").Value;
                    textBlockPais.Text = resposta.Element("resultado").Element("objeto").Element("perfil").Element("pais").Value;

                    textBlockGanhos.Text = resposta.Element("resultado").Element("objeto").Element("perfil").Element("jogos").Element("ganhos").Value;
                    textBlockPerdidos.Text = resposta.Element("resultado").Element("objeto").Element("perfil").Element("jogos").Element("perdidos").Value;

                    if (resposta.Element("resultado").Element("objeto").Element("perfil").Element("tempos").Element("Facil") == null)
                    {

                        textBlockMTempoFacil.Text = "Nao definido";
                    }
                    else
                    {
                        textBlockMTempoFacil.Text = resposta.Element("resultado").Element("objeto").Element("perfil").Element("tempos").Element("Facil").Value;
                    }


                    if (resposta.Element("resultado").Element("objeto").Element("perfil").Element("tempos").Element("Medio") == null)
                    {
                        textBlockMTempoMedio.Text = "Nao definido";
                    }
                    else
                    {
                        textBlockMTempoMedio.Text = resposta.Element("resultado").Element("objeto").Element("perfil").Element("tempos").Element("Medio").Value;
                    }



                    string base64Imagem = resposta.Element("resultado").Element("objeto").Element("perfil").Element("fotografia").Value;
                    string base64 = base64Imagem.Split(',')[1];
                    byte[] bytes = Convert.FromBase64String(base64);
                    var buf = bytes.AsBuffer();
                    var stream = buf.AsStream();
                    var image = stream.AsRandomAccessStream();
                    var decoder = await BitmapDecoder.CreateAsync(image);
                    image.Seek(0);
                    
                    var output = new WriteableBitmap((int)decoder.PixelHeight, (int)decoder.PixelWidth);
                    await output.SetSourceAsync(image);
                   
                    pictureBoxFoto.Stretch = Stretch.Fill;
                    pictureBoxFoto.Source = output;
                }

            }
            catch (Exception ex)
            {

                pictureBoxFoto.Stretch = Stretch.Fill;
                pictureBoxFoto.Source = null;


            }
            
        }
        
    }
}
