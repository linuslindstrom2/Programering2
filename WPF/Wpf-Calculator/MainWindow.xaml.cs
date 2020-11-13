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

        private void Enter_Click(object sender, RoutedEventArgs e)
        {

            List<int> container = new List<int>();
            


            if (e.Source is Button button)
            {
                string nummer = "";

                foreach (var item in InOutField.Text)
                {
                    if (item != '+' || item != '-' || item != '*' || item != '/' || item != '=')
                    {
                        nummer += item;
                    }
                    else
                    {
                        container.Add(Convert.ToInt32(nummer));

                        if (item == '+')
                        {
                            container.Add('+');
                        }
                        else if (item == '-')
                        {
                            container.Add('-');
                        }
                        else if (item == '*')
                        {
                            container.Add('*');
                        }
                        else if (item == '/')
                        {
                            container.Add('/');
                        }
                        else if (item == '=')
                        {
                            container.Add('=');
                        }
                    }
                }

                double sum = 0;

                if (container[1] == '+')
                {
                    sum = container[0] + container[2];
                }
                else if (container[1] == '-')
                {
                    sum = container[0] - container[2];
                }
                else if (container[1] == '*')
                {
                    sum = container[0] * container[2];
                }
                else if (container[1] == '/')
                {
                    sum = container[0] / container[2];
                }

                InOutField.Text += sum;

            }
        }


    }
}
