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
        Graph graph = new Graph();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            FirstSP.Visibility = Visibility.Collapsed;
            spSettingLabel.Visibility = Visibility.Visible;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnPChart_Click(object sender, RoutedEventArgs e)
        {
            spExport.Visibility = Visibility.Visible;
           

        }

        private void btnHGrahp_Click(object sender, RoutedEventArgs e)
        {
            spExport.Visibility = Visibility.Visible;
        }

        private void btnVGraph_Click(object sender, RoutedEventArgs e)
        {
            spExport.Visibility = Visibility.Visible;

        }

        private void btnTyping_Click(object sender, RoutedEventArgs e)
        {
            spManualInput.Visibility = Visibility.Visible;
            spTypyOfDiagram.Visibility = Visibility.Collapsed;
            spExport.Visibility = Visibility.Collapsed;
            int tb = Convert.ToInt32(tbFields.Text); //НЕ НРАВИТСЯ ЕМУ ЧТО ТО ТУТ

            graph.graphField.fieldQuantity = tb;
        }

        private void btnExcel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnJsonf_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            spValue.Visibility = Visibility.Visible;
        }
    }
}