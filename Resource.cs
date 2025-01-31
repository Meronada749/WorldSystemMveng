using InventorySystem;
using System;

namespace WorldSystem
{
    internal class Resource : IResource 
    {
        
        public Material Material { get; private set; }

        public Category Category { get; private set; }

        public int Price { get; private set; }

        public int Quantity { get; private set; }

        public Rarity Rarity { get; private set; }

        public int Weight { get; private set; }

        public Resource(Rarity Rarity, int Weight, Material Material, Category Category, int Price, int Quantity) 
        { 
            this.Rarity = Rarity;
            this.Weight = Weight;   
            this.Material = Material;
            this.Category = Category;
            this.Price = Price;
            this.Quantity = Quantity;
        }

        public void Display()
        {
            Console.WriteLine($"the {Category} is called {Material} it costs {Price} chf for {Quantity} it is very {Rarity} and it weighs {Weight} kilos.\n");
        }
    }
}
