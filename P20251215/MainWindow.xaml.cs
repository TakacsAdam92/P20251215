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
using NUnit.Framework;

namespace P20251215
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    [Test]
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void szamol_Click(object sender, RoutedEventArgs e)
        {
            DateTime date = DateTime.Now;
            szulev.Content = $"Születési éved: {date.Year - Convert.ToInt32(eletkor.Text)}";
        }
    }
}