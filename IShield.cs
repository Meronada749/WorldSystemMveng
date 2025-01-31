
/*
Entreprise : ETML
Auteur : Meron Essayas
Date : 24.01.2025
Description : Interface pour tous les objets
*/
using InventorySystem;

namespace WorldSystem
{
    internal interface IShield : IItem
    {
        int Protection { get; }

        Resource Resource { get; }

        Rarity Rarity { get; }
    }
}
