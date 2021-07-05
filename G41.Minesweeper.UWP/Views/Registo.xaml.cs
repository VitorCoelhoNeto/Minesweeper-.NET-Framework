using Minesweeper.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace G41.Minesweeper.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Registo : Page
    {
        Server serverLogin = null;
        public Registo()
        {
            this.InitializeComponent();
           
        }

        private async void buttonLogin_Click(object sender, RoutedEventArgs e)
        {

            string id = string.Empty;
            serverLogin = new Server();

            id = serverLogin.Login(textBoxUsername.Text, passwordBoxLogin.Password);

            if (!string.IsNullOrEmpty(id))
            {
                App.ID = id;
                App.username = textBoxUsername.Text;
                this.Frame.Navigate(typeof(MainPage));
            }
            else
            {
                var result = new MessageDialog("Conta Invalida!");
                await result.ShowAsync();
            }

        }

        private void buttonMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
