
using Microsoft.Win32;
using System.Runtime.CompilerServices;
using System.Text;
using Syncfusion.UI.Xaml.Charts;
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
        public string inte;
        Graph graph = new Graph();
       public string integ;
        List<GraphFieid> gv;


        public MainWindow()
        {
            InitializeComponent();

            gv = new List<GraphFieid>();

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
            graph.graphType = "PieChart";
           
        }

        private void btnHGrahp_Click(object sender, RoutedEventArgs e)
        {
            spExport.Visibility = Visibility.Visible;
            graph.graphType = "HGraph";
        }

        private void btnVGraph_Click(object sender, RoutedEventArgs e)
        {
            spExport.Visibility = Visibility.Visible;
            graph.graphType = "VGraph";

        }

        private void btnTyping_Click(object sender, RoutedEventArgs e)
        {
            spManualInput.Visibility = Visibility.Visible;
            spTypyOfDiagram.Visibility = Visibility.Collapsed;
            spExport.Visibility = Visibility.Collapsed;
            
        }

        private void btnExcel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnJsonf_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            JsonImport jsonImport = new JsonImport();
            openFileDialog.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
            bool? success = openFileDialog.ShowDialog();
            if (success == true)
            {
                jsonImport.path = openFileDialog.FileName;
                jsonImport.JI(out Graph graphj);
            }
            else { MessageBox.Show("File didnt choose", "MESSAGE", MessageBoxButton.OK, MessageBoxImage.Information); }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(gv.ToString(), "MESSAGE", MessageBoxButton.OK, MessageBoxImage.Information);

            //switch (graph.graphType)
            //{

            //    case "PieChart":

            //        break;
            //    case "HChart":

            //        break;
            //    case "VChart":

            //        break;

            //}
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            spValue.Visibility = Visibility.Visible;
            XamlFieldsCreater xamlFieldsCreater = new XamlFieldsCreater();
            integ = tbFields.Text;
            //xamlFieldsCreater.XFCreater();
            Graph graphField = new Graph();
            GraphFieid fieid = new GraphFieid();

            if (String.IsNullOrEmpty(integ))
            {
                MessageBox.Show("Enter something.", "MESSAGE", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                try
                {

                    graphField.fieldQuantity = int.Parse(integ);
                    int loopValue;
                    string loopName;
                    for (int i = 0; i < graphField.fieldQuantity; i++)
                    {
                        StackPanel stackPanel = new StackPanel()
                        {
                            Orientation = Orientation.Horizontal,
                            Name = "spForTwoFields" + i,

                        };
                        spValue.Children.Add(stackPanel);
                        Label label = new Label()
                        {
                            Content = "Enter name of graph:",

                        };
                        stackPanel.Children.Add(label);
                        TextBox textBox = new TextBox()
                        {
                            Name = "tbGraphName" + i,


                        };
                        stackPanel.Children.Add(textBox);
                        loopName = textBox.Text;
                        StackPanel stackPanel2 = new StackPanel()
                        {
                            Orientation = Orientation.Horizontal,
                            Name = "spForTwoFields" + i,

                        };
                        spValue.Children.Add(stackPanel2);
                        Label label2 = new Label()
                        {
                            Content = "Enter value of graph:",

                        };
                        stackPanel2.Children.Add(label2);
                        TextBox textBox2 = new TextBox()
                        {
                            Name = "tbGraphName" + i,
                        };
                        stackPanel2.Children.Add(textBox2);
                        loopValue = int.Parse(textBox2.Text);
                        gv.Add(new GraphFieid() { graphName = loopName, graphValue = loopValue });
                    }

                }
                catch
                {

                    MessageBox.Show("Enter the number.", "MESSAGE", MessageBoxButton.OK, MessageBoxImage.Information);
                }
               
            }
            spBtnCreate.Visibility = Visibility.Visible;
        }

    }
}