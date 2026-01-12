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

namespace Task3
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

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            if (!Agreement.IsChecked ?? false)
            {
                MessageBox.Show("Для записи необходимо согласие на обработку данных","Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var selectedCourses = Courses.SelectedItems.Cast<ListBoxItem>().Select(item => item.Content.ToString()).ToList();

            string message = $"Вы записаны!\n" +
                             $"Имя: {StudentName.Text}\n" +
                             $"Факультет:{Faculty.Text}\n" +
                             $"Курсы:{string.Join(",", selectedCourses)}\n" +
                             $"Согласие на обработку данных: {(Agreement.IsChecked == true ? "Да" : "Нет")}\n";

            MessageBox.Show(message, "Успех", MessageBoxButton.OK, MessageBoxImage.Information);

        }


    }
}