using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CurrencyCalculator
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

        private void Convert()
        {
            if (grn.Text.LastOrDefault() != ',' && euro.Text.LastOrDefault() != ',' && dollar.Text.LastOrDefault() != ',' && rub.Text.LastOrDefault() != ',')
            {
                if (grn.IsFocused && grn.Text != String.Empty)
                {
                    euro.Text = $"{Math.Round(30.52 * Double.Parse(grn.Text), 2)}";
                    dollar.Text = $"{Math.Round(26.32 * Double.Parse(grn.Text), 2)}";
                    rub.Text = $"{Math.Round(0.42 * Double.Parse(grn.Text), 2)}";
                }
                else if (euro.IsFocused && euro.Text != String.Empty)
                {
                    grn.Text = $"{Math.Round(30.52 * Double.Parse(euro.Text), 2)}";
                    dollar.Text = $"{Math.Round(1.16 * Double.Parse(euro.Text), 2)}";
                    rub.Text = $"{Math.Round(72.69 * Double.Parse(euro.Text), 2)}";
                }
                else if (dollar.IsFocused && dollar.Text != String.Empty)
                {
                    grn.Text = $"{Math.Round(26.32 * Double.Parse(dollar.Text), 2)}";
                    euro.Text = $"{Math.Round(0.86 * Double.Parse(dollar.Text), 2)}";
                    rub.Text = $"{Math.Round(62.69 * Double.Parse(dollar.Text), 2)}";
                }
                else if (rub.IsFocused && rub.Text != String.Empty)
                {
                    grn.Text = $"{Math.Round(0.42 * Double.Parse(rub.Text), 2)}";
                    euro.Text = $"{Math.Round(0.01 * Double.Parse(rub.Text), 2)}";
                    dollar.Text = $"{Math.Round(0.02 * Double.Parse(rub.Text), 2)}";
                }
                else
                    grn.Text = euro.Text = dollar.Text = rub.Text = "";
            }
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            Convert();
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void grn_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void rub_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void euro_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
