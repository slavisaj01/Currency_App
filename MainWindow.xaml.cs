using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Curency_Converter_Static
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BindCurency();
        }
        private void BindCurency()
        {
            DataTable dtCurency = new DataTable();
            dtCurency.Columns.Add("Text");
            dtCurency.Columns.Add("Value");
            dtCurency.Rows.Add("--SELECT--",0);
            dtCurency.Rows.Add("DIN", 1);
            dtCurency.Rows.Add("USD", 75);
            dtCurency.Rows.Add("EUR", 85);
            dtCurency.Rows.Add("SAR", 20);
            dtCurency.Rows.Add("POUND", 5);
            dtCurency.Rows.Add("DEM", 43);

            cmbFromCurency.ItemsSource=dtCurency.DefaultView;
            cmbFromCurency.DisplayMemberPath = "Text";
            cmbFromCurency.SelectedItem = "Value";
            cmbFromCurency.SelectedIndex = 0;

            cmbToCurency.ItemsSource = dtCurency.DefaultView;
            cmbToCurency.DisplayMemberPath = "Text";
            cmbToCurency.SelectedItem = "Value";
            cmbToCurency.SelectedIndex = 0;

        }
        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            lblCurency.Content = "proba";
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            lblCurency.Content = "";
            cmbFromCurency.SelectedIndex = 0;
            cmbToCurency.SelectedIndex = 0;
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}