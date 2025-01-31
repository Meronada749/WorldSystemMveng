
/*
Entreprise : ETML
Auteur : Meron Essayas
Date : 24.01.2025
Description : Interface pour tous les objets
*/
namespace WorldSystem
{
    internal interface IShield : InventorySystem.IItem
    {

        int Protection { get; }

        Resource Resource { get; }


    }
}
