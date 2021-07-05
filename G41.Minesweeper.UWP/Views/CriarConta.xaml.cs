using Minesweeper.Models;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace G41.Minesweeper.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CriarConta : Page
    {
        Server serverCC = null;
        public CriarConta()
        {
            serverCC = new Server();
            this.InitializeComponent();
        }

        private void buttonMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void buttonCriarConta_Click(object sender, RoutedEventArgs e)
        {
            serverCC.RegistarNovoUtilizador(textBoxUsername.Text, textBoxNome.Text, passwordBoxPass.Password, textBoxEmail.Text, textBoxFoto.Text, textBoxPais.Text);
        }
    }
}
