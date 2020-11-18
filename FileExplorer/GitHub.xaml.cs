using System;
using System.Collections.Generic;
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
    /// Logica di interazione per GitHub.xaml
    /// </summary>
    public partial class GitHub : Window
    {
        public GitHub()
        {
            InitializeComponent();
        }

        private void Chiudi(object sender, RoutedEventArgs e)
        {
            this.Close();
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
    }
}
