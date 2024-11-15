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

namespace Labo_9___MenuSliderBrushes
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

        private void closeMenu_Click(object sender, RoutedEventArgs e)
        {
            var answer =  MessageBox.Show("Wilt u de applicatie afsluiten?", "Afsluiten", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (answer == MessageBoxResult.Yes)
            {
                this.Close();
            }
            
                
        }

        private void firstNumberMenu_Click(object sender, RoutedEventArgs e)
        {
            numberOneTextBox.Text = "2";
        }

        private void secondNumberMenu_Click(object sender, RoutedEventArgs e)
        {
            numberTwoTextBox.Text = "2";
        }

        private void firstNumberSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            numberOneTextBox.Text = firstNumberSlider.Value.ToString();
        }

        private void secondNumberSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            numberTwoTextBox.Text = secondNumberSlider.Value.ToString();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(sender == numberOneTextBox)
            {
                firstNumberSlider.Value = double.Parse(numberOneTextBox.Text);
            }

            else if(sender == numberTwoTextBox)
            {
                secondNumberSlider.Value = double.Parse(numberTwoTextBox.Text);
            }
        }
    }
}