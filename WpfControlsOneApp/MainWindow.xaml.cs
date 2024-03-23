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

namespace WpfControlsOneApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<RadioButton> items;

        public MainWindow()
        {
            InitializeComponent();

            CheckBox chinaCheck = new() { Content = "Chines" };
            chinaCheck.IsChecked = true;
            stack.Children.Add(chinaCheck);

            items = new();

            for(int i = 0; i < 5; i++)
            {
                items.Add(new RadioButton { Content = $"Item {i}" });
                stack.Children.Add(items[i]);
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text = "";
            foreach(var i in items)
                if (i.IsChecked == true)
                {
                    text = i.Content.ToString();
                    break;
                }

            MessageBox.Show(text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Cancel button click");
        }

        private void ru_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ru checked");
        }

        private void ru_Indeterminate(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ru Indeterminate");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if(sender is RadioButton radio)
            {
                MessageBox.Show(radio.Content.ToString());
            }
        }
    }
}