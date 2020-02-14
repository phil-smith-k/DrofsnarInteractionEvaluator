using System;
using System.Collections.Generic;
using DrofsnarClassLibrary;
using System.Threading;

namespace DrosfnarUI
{
    partial class Program
    {
        public class ProgramUI
        {
            public void Run(List<IInteraction> interactions)
            {
                Drofsnar drofsnar = new Drofsnar();

                foreach (IInteraction interaction in interactions)
                {
                    drofsnar.EvaluateInteraction(interaction);
                    if (interaction is InvincibleBirdHunter)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{drofsnar.Points} {drofsnar.Lives} {interaction.Name}");
                        Console.ResetColor();
                    }
                    else if (interaction is VulnerableBirdHunter)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{drofsnar.Points} {drofsnar.Lives} {interaction.Name}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"{drofsnar.Points} {drofsnar.Lives} {interaction.Name}");
                    }
                    if (drofsnar.Lives == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Game Over");
                        Console.ResetColor();
                        break;
                    }
                    Thread.Sleep(50);
                }
            }
        }
    }
}
