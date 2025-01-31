/*
Entreprise : ETML
Auteur : Christopher Ristic 
Date : 17.01.2025
Description : Interface pour les ressources
*/

using WorldSystem;

namespace InventorySystem
{
    internal interface IResource : IItem
    {
        Rarity Rarity { get; }
        int Weight { get; }
    }
}
