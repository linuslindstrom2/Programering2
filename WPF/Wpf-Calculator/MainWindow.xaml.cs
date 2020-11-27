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

namespace Wpf_Calculator
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                InOutField.Text += button.Content;
            }
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                InOutField.Text = String.Empty;
            }
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {

            
            if (e.Source is Button button)
            {
               
                
                String textruta = InOutField.Text;

                if (textruta.Contains('-') && textruta.Contains('+') || textruta.Contains('*') || textruta.Contains('/'))
                {

                    if (InOutField.Text.Contains('+'))
                    {
                        String[] tal = textruta.Split('+');

                        InOutField.Text = String.Empty;
                        InOutField.Text += Convert.ToDouble(tal[0]) + Convert.ToDouble(tal[1]);
                    }
                    else if (InOutField.Text.Contains('*'))
                    {
                        String[] tal = textruta.Split('*');

                        InOutField.Text = String.Empty;
                        InOutField.Text += Convert.ToDouble(tal[0]) * Convert.ToDouble(tal[1]);
                    }
                    else if (InOutField.Text.Contains('/'))
                    {
                        String[] tal = textruta.Split('/');

                        InOutField.Text = String.Empty;
                        InOutField.Text += Convert.ToDouble(tal[0]) / Convert.ToDouble(tal[1]);
                    }
                }
                else if (textruta.Contains('-') ) 
                {

                }
                
                starts with

                börjar på + * /, error

            }
        }
    }
}


if (InOutField.Text.Contains('+'))
{
    String[] tal = textruta.Split('+');

    InOutField.Text = String.Empty;
    InOutField.Text += Convert.ToDouble(tal[0]) + Convert.ToDouble(tal[1]);
}
else if (InOutField.Text.Contains('-'))
{
    String[] tal = textruta.Split('-');

    InOutField.Text = String.Empty;
    InOutField.Text += Convert.ToDouble(tal[0]) - Convert.ToDouble(tal[1]);
}
else if (InOutField.Text.Contains('*'))
{
    String[] tal = textruta.Split('*');

    InOutField.Text = String.Empty;
    InOutField.Text += Convert.ToDouble(tal[0]) * Convert.ToDouble(tal[1]);
}
else if (InOutField.Text.Contains('/'))
{
    String[] tal = textruta.Split('/');

    InOutField.Text = String.Empty;
    InOutField.Text += Convert.ToDouble(tal[0]) / Convert.ToDouble(tal[1]);
}
else
{
    InOutField.Text += "Error";
}
