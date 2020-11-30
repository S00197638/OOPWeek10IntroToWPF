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

namespace Exercise5
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

        private void btnStartGame_Click(object sender, RoutedEventArgs e)
        {
            bool startGame = true;
            tblkInitialNum.Text = "";
            tblkSecondNum.Text = "";
            radbtnBigger.IsChecked = false;
            radbtnSmaller.IsChecked = false;
            tblkGameOver.Text = "";
            Update(startGame);
        }

        private void btnGuess_Click(object sender, RoutedEventArgs e)
        {
            bool startGame = false;

            Update(startGame);
            CheckNumber();
        }

        public async void Update(bool gameStart)
        {
            Random rng = new Random();

            int randomNumber;

            if (gameStart)
            {
                for (int i = 0; i < 20; i++)
                {
                    randomNumber = rng.Next(1, 21);

                    tblkInitialNum.Text = randomNumber.ToString();

                    await Task.Delay(50);
                }
            }
            else
            {
                for (int i = 0; i < 20; i++)
                {
                    randomNumber = rng.Next(1, 21);

                    tblkSecondNum.Text = randomNumber.ToString();

                    await Task.Delay(50);
                }
            }
        }

        public void CheckNumber()
        {
            int initialNum;
            int secondNum;
            bool isNum = int.TryParse(tblkInitialNum.Text, out initialNum);
            bool isNumber = int.TryParse(tblkSecondNum.Text, out secondNum);
            bool biggerChecked = radbtnBigger.IsChecked.Value;
            bool smallerChecked = radbtnSmaller.IsChecked.Value;

            if(isNum && isNumber)
            {
                if(biggerChecked)
                {
                    if(secondNum > initialNum)
                        tblkGameOver.Text = "You Win";
                    else if(secondNum == initialNum)
                        tblkGameOver.Text = "You Lose";
                    else
                        tblkGameOver.Text = "You Lose";
                }

                if(smallerChecked)
                {
                    if(secondNum < initialNum)
                        tblkGameOver.Text = "You Win";
                    else if (secondNum == initialNum)
                        tblkGameOver.Text = "You Lose";
                    else
                        tblkGameOver.Text = "You Lose";
                }

                if((bool)radbtnBigger.IsChecked == false && (bool)radbtnSmaller.IsChecked == false)
                {
                    tblkGameOver.Text = "You Must Guess Bigger / Smaller";
                }
            }
            else
            {
                tblkGameOver.Text = "Invalid Input!";
            }
        }
    }
}
