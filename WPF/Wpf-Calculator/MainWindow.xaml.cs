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

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                InOutField.Text += '-';
            }
        }

        private void Negative_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                InOutField.Text += '-';
            }
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                InOutField.Text = String.Empty;
            }
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {


            if (e.Source is Button button)
            {


                String textruta = InOutField.Text;


                if (textruta.Contains('+'))
                {
                    String[] tal = textruta.Split('+');

                    InOutField.Text = String.Empty;
                    InOutField.Text += Convert.ToDouble(tal[0]) + Convert.ToDouble(tal[1]);
                }
                else if (textruta.Contains('*'))
                {
                    String[] tal = textruta.Split('*');

                    InOutField.Text = String.Empty;
                    InOutField.Text += Convert.ToDouble(tal[0]) * Convert.ToDouble(tal[1]);
                }
                else if (textruta.Contains('/'))
                {
                    String[] tal = textruta.Split('/');

                    InOutField.Text = String.Empty;
                    InOutField.Text += Convert.ToDouble(tal[0]) / Convert.ToDouble(tal[1]);
                }
                else if (textruta.Contains('^'))
                {
                    String[] tal = textruta.Split('^');

                    double sum = Convert.ToDouble(tal[0]);
                    
                    for (int i = 1; i<Convert.ToDouble(tal[1]); i++)
                    {
                        sum *= Convert.ToDouble(tal[0]);
                    }

                    InOutField.Text = String.Empty;
                    InOutField.Text += sum;
                }
                else if (textruta.Contains('-'))
                {
                    if (textruta.StartsWith("-"))
                    {
                        textruta = textruta.Substring(1);
                        String[] tal = textruta.Split(new[] { '-' }, 2);

                        double tal1 = 0 - Convert.ToDouble(tal[0]);
                        InOutField.Text = String.Empty;

                        InOutField.Text += tal1 - Convert.ToDouble(tal[1]);
                    }
                    else
                    {
                        String[] tal = textruta.Split(new[] { '-' }, 2);

                        InOutField.Text = String.Empty;
                        InOutField.Text += Convert.ToDouble(tal[0]) - Convert.ToDouble(tal[1]);
                    }
                }
            }
        }
    }
}