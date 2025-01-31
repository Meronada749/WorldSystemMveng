using InventorySystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSystem
{
    internal interface ISword : IItem
    {
        int Damage { get; }

        Resource Resource { get; }

        Rarity Rarity { get; }

    }
}
