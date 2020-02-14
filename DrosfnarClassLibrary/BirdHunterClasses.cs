using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrofsnarClassLibrary
{
    public class VulnerableBirdHunter : IInteraction
    {
        public string Name { get; } = "VulnerableBirdHunter";
        private static int _pointmultiplier = 1;
        public VulnerableBirdHunter()
        {
            this.Points = _pointmultiplier * 200;
            _pointmultiplier *= 2;
        }
        public int Points { get; }
        public int Lives { get; } = 0;
    }
    public class InvincibleBirdHunter : IInteraction
    {
        public string Name { get; } = "InvincibleBirdHunter";
        public int Points { get; } = 0;
        public int Lives { get; } = -1;
    }
}
