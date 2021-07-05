using Minesweeper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Linq;
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
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace G41.Minesweeper.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            logadoComo();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private /*async*/ void Button_Click_1(object sender, RoutedEventArgs e)
        {
            /*MediaElement mediaElement = new MediaElement(); //teste
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("Olá");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();*/

           //BlankPage1 facil = new BlankPage1();
      
            
                this.Frame.Navigate(typeof(TestarPanel));
           
            

        }

        private void buttonJogarIntermedio_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Intermedio));
        }

        private void buttonSair_Click(object sender, RoutedEventArgs e)
        { 
            CoreApplication.Exit();
        }

        private void buttonAjuda_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Ajuda));
        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Registo));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.ID = string.Empty;
            App.username = string.Empty;
            logadoComo();
        }

        private void logadoComo()
        {
            if (!string.IsNullOrEmpty(App.username))
            {
                textBlockUserInicio.Text = App.username;
            }
            else
            {
                textBlockUserInicio.Text = "Offline";
            }
            
        }

        private void buttonPerfis_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Perfis));
        }

        private void buttonCriarConta_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CriarConta));
        }

        private void buttonLeaderboards_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Leaderboards));
        }
    }
}
