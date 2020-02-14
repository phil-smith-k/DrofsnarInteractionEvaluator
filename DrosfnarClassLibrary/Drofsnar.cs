using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrofsnarClassLibrary
{
    public class Drofsnar
    {
        private static bool _hasReachedTenThousand;
        private int _points = 5000;
        private int _lives = 3;
        public Drofsnar() { }
        public Drofsnar(int points, int lives)
        {
            this._points = points;
            this._lives = lives;
        }
        public int Points
        {
            get
            {
                return this._points;
            }
            private set
            {
                _points = value;
                if (this._points > 10000 && _hasReachedTenThousand == false)
                {
                    this.Lives++;
                    _hasReachedTenThousand = true;
                }
            }
        }
        public int Lives
        {
            get => this._lives;
            set => _lives = value;
        }
        public void EvaluateInteraction(IInteraction interaction)
        {
            this.Points += interaction.Points;
            this.Lives += interaction.Lives;
        }
    }
}
