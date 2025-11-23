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

namespace Test;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    int counter = 0;
    public MainWindow()
    {
        InitializeComponent();
        Counter.Text = counter.ToString();

    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        counter++;
        Counter.Text = counter.ToString();

    }
}