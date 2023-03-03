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

namespace samostoyatelnaya
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

        private void tbn_button_clik(object sender, RoutedEventArgs e)
        {

        }


       

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {

        }


        public void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
          
        }


        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void baton_click(object sender, RoutedEventArgs e)
        {
           MessageBox.Show(new Random().Next(5,100000).ToString() + "рублей");
        }
    }
}
