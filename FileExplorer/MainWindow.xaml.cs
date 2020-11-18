using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FileExplorer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string FrancyINK = @"C:\Program Files\Cutotopo\FrancyInk\RunFSMode.exe";
        private const string FrinowareCloudApp = @"C:\Program Files\Cutotopo\Frinoware Cloud\Frinoware Cloud.exe";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CaricaUri(object sender, RoutedEventArgs e)
        {
            string serveruri = uribar.Text;
            Uri uri = new Uri(this.uribar.Text, UriKind.RelativeOrAbsolute);
            if (!uri.IsAbsoluteUri)
            {
                MessageBox.Show("Percorso non valido.");
                return;
            }
            Browser.Navigate(uri);
            Title = serveruri;
        }

        private void Indietro(object sender, RoutedEventArgs e)
        {
            Browser.GoBack();
        }

        private void Avanti(object sender, RoutedEventArgs e)
        {
            Browser.GoForward();
        }

        private void Aggiorna(object sender, RoutedEventArgs e)
        {
            Browser.Refresh();
        }

        private void BrowserLoad(object sender, RoutedEventArgs e)
        {
            var navigateuri = Browser.Source;
            uribar.Text = "navigateuri";
        }

        private void CMD(object sender, RoutedEventArgs e)
        {
            var serveruri = uribar.Text;
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.FileName = "cmd.exe";
            processInfo.WorkingDirectory = serveruri;
            System.Diagnostics.Process.Start(processInfo);
        }

        private void TopmostBtn(object sender, RoutedEventArgs e)
        {
            this.Topmost = true;
            notopmost.Visibility = Visibility.Visible;
            TopmostOn.Visibility = Visibility.Hidden;
        }

        private void TopmostOffBtn(object sender, RoutedEventArgs e)
        {
            this.Topmost = false;
            notopmost.Visibility = Visibility.Hidden;
            TopmostOn.Visibility = Visibility.Visible;
        }

        private void GitHubButton(object sender, RoutedEventArgs e)
        {
            GitHub git = new GitHub();
            git.Show();
        }

        private void FrancyInk(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(FrancyINK);
        }

        private void FrinowareCloud(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(FrinowareCloudApp);
        }
    }
}
