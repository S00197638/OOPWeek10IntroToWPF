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

namespace Exercise4
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

        private void tbxInput_GotFocus(object sender, RoutedEventArgs e)
        {
            tbxInput.Clear();
            tbxInput.Background = Brushes.White;
        }

        private void btnButton1_Click(object sender, RoutedEventArgs e)
        {
            //Read Number from TextBox
            string input = tbxInput.Text;

            //Check If it is a Valid Number
            int number;
            bool isNum = int.TryParse(input, out number);

            //Display Appropriate Message
            if (isNum)
            {
                MessageBox.Show("Value Entered is a Valid Number!");
                tbxInput.Background = Brushes.Green;
            }
            else
            {
                MessageBox.Show("Value Entered is not a Valid Number!");
                tbxInput.Background = Brushes.Red;
            }
        }
    }
}
