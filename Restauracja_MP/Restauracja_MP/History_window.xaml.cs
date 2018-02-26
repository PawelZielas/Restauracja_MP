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
using System.Windows.Shapes;

namespace Restauracja_MP
{
    /// <summary>
    /// Logika interakcji dla klasy history_window.xaml
    /// </summary>
    public partial class history_window : Window
    {
        public history_window()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void HistoryBackBtn(object sender, RoutedEventArgs e)
        {
            this.Close();
            App.Current.MainWindow.Show();
        }

        private void ShowDetails(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Nie zaznaczyłeś żadnego zamówienia z histori !", "Szczegoly zamówienia");
        }
    }
}
