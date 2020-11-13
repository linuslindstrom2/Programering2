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

namespace Wpf_lektion
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

        private void Comma_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                InOutField.Text += button.Content;
            }
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                InOutField.Text += button.Content;
            }
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                InOutField.Text += button.Content;
            }
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                InOutField.Text += button.Content;
            }
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                InOutField.Text += button.Content;
            }
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                InOutField.Text += button.Content;
            }
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                InOutField.Text += button.Content;
            }
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                InOutField.Text += button.Content;
            }
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                InOutField.Text += button.Content;
            }
        }


        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                InOutField.Text += button.Content;
            }
        }


        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                InOutField.Text += button.Content;
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                InOutField.Text += button.Content;
            }
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
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
                InOutField.Text += button.Content;
            }
        }

        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                InOutField.Text += button.Content;
            }
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                InOutField.Text += button.Content;
            }
        }
    }
}
