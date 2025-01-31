using InventorySystem;
using System;

namespace WorldSystem
{
    internal class Sword : ISword
    {
        //Properties
        public string Name { get; private set; }
        public Category Category { get; private set; }
        public int Price { get; private set; }
        public int Quantity { get; private set; }
        public int Damage { get; private set; }
        public Resource Resource { get; private set; }
        public Rarity Rarity { get; private set; }


        /// <summary>
        /// Custom Constructor
        /// </summary>
        /// <param name="Name">nom de l'objet</param>
        /// <param name="Category">categorie de l'objet</param>
        /// <param name="Price">prix de l'objet</param>
        /// <param name="Quantity">quantite de l'objet</param>
        public Sword(string Name, Category Category, int Price, int Quantity, int Damage, Resource Resource, Rarity Rarity)
        {
            this.Name = Name;
            this.Category = Category;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Damage = Damage;
            this.Resource = Resource;
            this.Rarity = Rarity;
        }

        /// <summary>
        /// Display the sword
        /// </summary>
        public void DisplaySword()
        {
            Console.WriteLine($"The {Category} is called {Name} and it can deal {Damage} damage. It is {Rarity} rarity. It is made of {Resource.Material} and it costs {Price} coins.\n");
        }
    }
}
