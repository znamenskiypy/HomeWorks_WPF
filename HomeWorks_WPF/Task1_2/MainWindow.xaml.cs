using System.Diagnostics.Metrics;
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

namespace Task1_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

            Redlight.Fill = Brushes.Gray;
            Yellowlight.Fill = Brushes.Gray;
            Greenlight.Fill = Brushes.Gray;
        }

        int counter = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            counter++;

            if (counter % 3 == 1)
            {
                Redlight.Fill = Brushes.Red;
                Yellowlight.Fill = Brushes.Gray;
                Greenlight.Fill = Brushes.Gray;
            }
            else if (counter % 3 == 2)
            {
                Yellowlight.Fill = Brushes.Yellow;
                Redlight.Fill = Brushes.Gray;
                Greenlight.Fill = Brushes.Gray;
            }
            else if (counter % 3 == 0)
            {
                Greenlight.Fill = Brushes.Green;
                Redlight.Fill = Brushes.Gray;
                Yellowlight.Fill = Brushes.Gray;
            }
        }

        

    }
}