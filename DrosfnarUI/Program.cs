using DrofsnarClassLibrary;
using System.Collections.Generic;

namespace DrosfnarUI
{
    partial class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\pksmi\Documents\ElevenFiftyProjects\GoldBadge\game-sequence.txt";
            DataReader dataReader = new DataReader();
            List<IInteraction> interactions = dataReader.ProcessData(filepath);

            ProgramUI ui = new ProgramUI();
            ui.Run(interactions);
        }
    }
}
