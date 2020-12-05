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

namespace Exercise7
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

        private void tbxPlayerName_GotFocus(object sender, RoutedEventArgs e)
        {
            tbxPlayerName.Clear();
            tbxPlayerName.Background = Brushes.White;
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            bool startGame = false;
            int score = 0;

            if (tbxPlayerName.Text == "" || tbxPlayerName.Text == "Player Name...")
            {
                MessageBox.Show("No Name Entered!  Please Enter your Player Name!");
                tbxPlayerName.Text = "Player Name...";
                tbxPlayerName.Background = Brushes.Red;
                startGame = false;
            }
            else
            {
                tblkUser.Text = tbxPlayerName.Text;
                tblkScore.Text = score.ToString();
                tbxPlayerName.Background = Brushes.Green;
                startGame = true;
            }

            if(startGame)
            {
                UpdatePlayerNumber();
                UpdateRandom();
            }
        }

        public void UpdatePlayerNumber()
        {
            Random rng = new Random();
            int playerNumber = 0;
            playerNumber = rng.Next(1, 11);
            tblkPlayerNumber.Text = playerNumber.ToString();
        }

        public async void UpdateRandom()
        {
            Random rng = new Random();
            int randomNumber;

            for (int i = 0; i < 10; i++)
            {
                randomNumber = rng.Next(1, 11);

                tblkNumberToGet.Text = randomNumber.ToString();

                await Task.Delay(50);
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            btnNext.Background = Brushes.White;
            UpdateRandom();
        }

        private void btnSnap_Click(object sender, RoutedEventArgs e)
        {
            string playerNumString = tblkPlayerNumber.Text;
            string numString = tblkNumberToGet.Text;
            int playerNum;
            int number;
            bool isNumPlayer = int.TryParse(playerNumString, out playerNum);
            bool isNum = int.TryParse(numString, out number);

            if(isNumPlayer && isNum)
            {
                if(playerNum == number)
                {
                    MessageBox.Show("SNAP!");
                    UpdateScore();
                    UpdatePlayerNumber();
                    UpdateRandom();
                }
                else
                {
                    MessageBox.Show("Not The Same!  Try Again!");
                    btnNext.Background = Brushes.Yellow;
                }
            }
        }

        public void UpdateScore()
        {
            string scoreString = tblkScore.Text;
            int scoreNum;
            bool isNumScore = int.TryParse(scoreString, out scoreNum);

            if(isNumScore)
            {
                if(scoreNum == 2)
                {
                    scoreNum++;
                    tblkScore.Text = scoreNum.ToString();
                    MessageBox.Show("You Won!");
                }
                else
                {
                    scoreNum++;
                    tblkScore.Text = scoreNum.ToString();
                }
            }
        }
    }
}
