using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrofsnarClassLibrary
{
    public class Bird : IInteraction
    {
        public string Name { get; } = "Bird";
        public int Points { get; } = 10;
        public int Lives { get; } = 0;
    }
    public class CrestedIbis : IInteraction
    {
        public string Name { get; } = "CrestedIbis";
        public int Points { get; } = 100;
        public int Lives { get; } = 0;
    }
    public class GreatKiskudee : IInteraction
    {
        public string Name { get; } = "GreatKiskudee";
        public int Points { get; } = 300;
        public int Lives { get; } = 0;
    }
    public class RedCrossbill : IInteraction
    {
        public string Name { get; } = "RedCrossbill";
        public int Points { get; } = 500;
        public int Lives { get; } = 0;
    }
    public class RedNeckedPhalarope : IInteraction
    {
        public string Name { get; } = "RedNeckedPhalarope";
        public int Points { get; } = 700;
        public int Lives { get; } = 0;
    }
    public class EveningGrosbeak : IInteraction
    {
        public string Name { get; } = "EveningGrosbeak";
        public int Points { get; } = 1000;
        public int Lives { get; } = 0;
    }
    public class GreaterPrairieChicken : IInteraction
    {
        public string Name { get; } = "GreaterPrarieChicken";
        public int Points { get; } = 2000;
        public int Lives { get; } = 0;
    }
    public class IcelandGull : IInteraction
    {
        public string Name { get; } = "IcelandGull";
        public int Points { get; } = 3000;
        public int Lives { get; } = 0;
    }
    public class OrangeBelliedParrot : IInteraction
    {
        public string Name { get; } = "OrangeBelliedParrot";
        public int Points { get; } = 5000;
        public int Lives { get; } = 0;
    }
}
