using InventorySystem;
using System;
using static System.Net.Mime.MediaTypeNames;
/*
Entreprise : ETML
Auteur : Meron Essayas
Date : 24.01.2025
Description : 
*/
namespace WorldSystem
{
    internal class Shield : IShield
    {
        //Properties
        public string Name { get; private set; }
        public Category Category { get; private set; }
        public int Price {  get; private set; }
        public int Quantity { get; private set; }
        public int Protection { get; private set; }
        public Resource Resource { get; private set; }
        public Rarity Rarity { get; private set; }

        /// <summary>
        /// Custom Constructor
        /// </summary>
        /// <param name="Name">nom de l'objet</param>
        /// <param name="Category">categorie de l'objet</param>
        /// <param name="Price">prix de l'objet</param>
        /// <param name="Quantity">quantite de l'objet</param>
        /// 
        public Shield(string Name, Category Category, int Price, int Quantity, int Protection, Resource Resource, Rarity Rarity) 
        {
            this.Name = Name;
            this.Category = Category;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Protection = Protection;
            this.Resource = Resource;
            this.Rarity = Rarity;
        }

        /// <summary>
        ///Display the shield 
        /// </summary>
        public void DisplayShield()
        {
            Console.WriteLine($"The {Category} is called {Name} and it can hurt you by {Protection} damage. It is {Rarity} rarity. It is made of {Resource.Material} and it costs {Price} coins.\n");
        }
    }
}
