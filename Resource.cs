/*
Entreprise : ETML
Auteur : Meron Essayas
Date : 24.01.2025
Description : 
*/

using System;

namespace WorldSystem
{
    internal class Resource : InventorySystem.IResource 
    {
        
        public Material Material { get; private set; }

        public InventorySystem.Category Category { get; private set; }

        public int Price { get; private set; }

        public int Quantity { get; private set; }

        public InventorySystem.Rarity Rarity { get; private set; }

        public int Weight { get; private set; }

        public Resource(InventorySystem.Rarity Rarity, Material Material, InventorySystem.Category Category, int Price, int Quantity) 
        { 
            this.Rarity = Rarity;
            this.Weight = (int)Material * Quantity;   
            this.Material = Material;
            this.Category = Category;
            this.Price = Price;
            this.Quantity = Quantity;
        }

        public void DisplayResource()
        {
            Console.WriteLine($"the {Category} is called {Material} it costs {Price} chf for {Quantity} it is very {Rarity} and it weighs {Weight} kilos.\n");
        }
    }
}
