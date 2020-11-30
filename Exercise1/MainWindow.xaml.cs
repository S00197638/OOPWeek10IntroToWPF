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

namespace Exercise1
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

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            //Read Data Entered into Text Box
            string input = tbxInput.Text;

            //Display Text from Text Box in Text Block
            tblkDisplay.Text = input;

        }

        private void tbxInput_GotFocus(object sender, RoutedEventArgs e)
        {
            tbxInput.Text = "";
            tblkDisplay.Text = "";
        }
    }
}
