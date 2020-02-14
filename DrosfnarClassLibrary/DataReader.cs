using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrofsnarClassLibrary
{
    public class DataReader
    {
        private List<IInteraction> _interactions { get; set; }
        
        private List<IInteraction> ParseInteractions(List<string> interactionList)
        {
            List<IInteraction> resultList = new List<IInteraction>();
            foreach (string interaction in interactionList)
            {
                switch (interaction.ToLower())
                {
                    case "bird":
                        resultList.Add(new Bird());
                        break;
                    case "crestedibis":
                        resultList.Add(new CrestedIbis());
                        break;
                    case "greatkiskudee":
                        resultList.Add(new GreatKiskudee());
                        break;
                    case "redcrossbill":
                        resultList.Add(new RedCrossbill());
                        break;
                    case "red-neckedphalarope":
                        resultList.Add(new RedNeckedPhalarope());
                        break;
                    case "eveninggrosbeak":
                        resultList.Add(new EveningGrosbeak());
                        break;
                    case "greaterprairiechicken":
                        resultList.Add(new GreaterPrairieChicken());
                        break;
                    case "icelandgull":
                        resultList.Add(new IcelandGull());
                        break;
                    case "orange-belliedparrot":
                        resultList.Add(new OrangeBelliedParrot());
                        break;
                    case "vulnerablebirdhunter":
                        resultList.Add(new VulnerableBirdHunter());
                        break;
                    case "invinciblebirdhunter":
                        resultList.Add(new InvincibleBirdHunter());
                        break;
                    default:
                        break;
                }
            }
            return resultList;
        }
        public List<IInteraction> ProcessData(string filepath)
        {
            string interactionText = File.ReadAllText(filepath);
            List<string> listOfInteractions = interactionText.Split(',').ToList();
            return ParseInteractions(listOfInteractions);
        }
    }
}
