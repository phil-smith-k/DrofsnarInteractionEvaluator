using System;
using DrofsnarClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DrosfnarTests
{
    [TestClass]
    public class BirdHuntertests
    {
        [TestMethod]
        public void VunerableBirdHunters_ShouldDoublePointValue()
        {
            VulnerableBirdHunter birdhunter1 = new VulnerableBirdHunter();
            VulnerableBirdHunter birdhunter2 = new VulnerableBirdHunter();
            VulnerableBirdHunter birdhunter3 = new VulnerableBirdHunter();

            Console.WriteLine(birdhunter1.Points);
            Console.WriteLine(birdhunter2.Points);
            Console.WriteLine(birdhunter3.Points);
        }
    }
}
