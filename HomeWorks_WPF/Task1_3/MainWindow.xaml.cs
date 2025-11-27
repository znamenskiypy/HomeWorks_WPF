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

namespace Task1_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Thickness buttonMargin;
        
        public MainWindow()
        {
            InitializeComponent();
            buttonMargin = new Thickness();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            int xmax = Convert.ToInt32(myGrid.ActualWidth-button.Width/2);
            int ymax = Convert.ToInt32(myGrid.ActualHeight-button.Height/2);
            Random random = new Random();

            int x = random.Next (0, xmax);
            int y = random.Next (0, ymax);
            
            button.Margin = buttonMargin;
            buttonMargin.Bottom = y;
            buttonMargin.Left = x;

        }
    }
}