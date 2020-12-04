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

        private void Window_Activated(object sender, EventArgs e)
        {
            Game game1 = new Game("ASSASSIN'S CREED: VALHALLA", 68, Genre.RPG);
            Game game2 = new Game("OVERWATCH", 189, Genre.FPS);
            Game game3 = new Game("FORTNITE", 25, Genre.BattleRoyale);

        }

        private void DisplayGames()
        {
            //Console.WriteLine("\n{0, -35}{1, -15}{2, -20}", "Title", "Hours Played", "Genre");

            //foreach (Song song in playlist)
            //{
            //    Console.WriteLine(song);
            //}
        }
    }
}
