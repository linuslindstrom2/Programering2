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

namespace hej
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
            if (ApaText.text=="Apa")
            {
                ApaText.Text = "Bepa";

            }else if(ApaText.Text=="Bepa")
            {
                var newBUtton = new Button();
                newBUtton.Content = "Ny Knapp";
                newBUtton.Width = 30;
                newBUtton.Height = 50;

            }
            else
            {
                
            }
            ApaText.Text = "Apa";
        }
    }
}
