using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrofsnarClassLibrary
{
    public interface IInteraction
    {
        string Name { get; }
        int Points { get; }
        int Lives { get; }
    }
}
