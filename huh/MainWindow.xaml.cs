using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace huh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            FirstSP.Visibility = Visibility.Collapsed;
            SettingsSP.Visibility = Visibility.Visible;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnPChart_Click(object sender, RoutedEventArgs e)
        {

        }


        private void btnHGrahp_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnVGraph_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}