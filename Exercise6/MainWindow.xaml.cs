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

namespace Exercise6
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
            tblkResult.Text = "";
            tblkResult.Background = Brushes.White;
        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            string input = tbxInput.Text;
            int number;
            bool isNum = int.TryParse(input, out number);

            if(isNum)
            {
                bool isEven = CheckIfEven(number);
                DisplayResult(isEven);
            }
            else
            {
                MessageBox.Show("Value Entered is not a Valid Number!");
                tbxInput.Text = "Enter Number...";
                tbxInput.Background = Brushes.Red;
                tblkResult.Text = "";
                tblkResult.Background = Brushes.White;
            }
        }

        public bool CheckIfEven(int number)
        {
            if (number % 2 == 0)
                return true;
            else
                return false;
        }

        public void DisplayResult(bool isEven)
        {
            if (isEven)
            {
                tblkResult.Text = "Number Entered Is Even!";
                tblkResult.Background = Brushes.Green;
            }
            else
            {
                tblkResult.Text = "Number Entered Is Odd!";
                tblkResult.Background = Brushes.Orange;
            }
        }
    }
}
