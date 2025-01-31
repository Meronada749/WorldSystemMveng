/*
Entreprise : ETML
Auteur : Christopher Ristic 
Date : 17.01.2025
Description : Interface pour tous les objets
*/
namespace InventorySystem
{
    internal interface IItem
    {
        WorldSystem.Material Material { get; }
        Category Category { get; }
        int Price { get; }
        int Quantity { get; }
        Rarity Rarity { get; }
    }
}
