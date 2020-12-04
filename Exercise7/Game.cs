using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    public enum Genre { RPG, FPS, BattleRoyale, Other }
    class Game : IComparable
    {
        #region Properties

        public string Title { get; set; }

        public Genre GameGenre { get; set; }

        public double HoursPlayed { get; set; }

        #endregion

        #region Constructors

        public Game(string title, double hoursPlayed, Genre gameGenre)
        {
            Title = title;
            HoursPlayed = hoursPlayed;
            GameGenre = gameGenre;
        }

        public Game(string title, double hoursPlayed) : this(title, hoursPlayed, Genre.Other) { }

        public Game() : this("Unknown", 0) { }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format($"{Title,-35}{HoursPlayed,-15}{GameGenre,-20}");

        }//End of ToString Method

        public int CompareTo(object otherObject, int sortBy)
        {
            Game that = (Game)otherObject;
            int returnValue = 0;

            if(sortBy == 1)
                returnValue = this.Title.CompareTo(that.Title);//Sort by Title
            else if(sortBy == 2)
                returnValue = this.HoursPlayed.CompareTo(that.HoursPlayed);//Sort by HoursPlayed
            else if(sortBy == 3)
                returnValue = this.GameGenre.CompareTo(that.GameGenre);//Sort by GameGenre

            return returnValue;

        }//End of CompareTo Method

        #endregion

    }//End of Game Class
}
