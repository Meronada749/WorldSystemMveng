/*
Entreprise : ETML
Auteur : Meron Essayas
Date : 24.01.2025
Description : 
*/
using InventorySystem;
using System;
using System.Collections.Generic;
using System.Linq;


namespace WorldSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Array mat = Enum.GetValues(typeof(Material));
            Material materialRandom = (Material)mat.GetValue(random.Next(mat.Length));

            List<IItem> worldItems = new List<IItem>()
            {
                 new Resource(Rarity: Rarity.Legendary, Material:materialRandom,  Category: Category.Resource, Price:100, Quantity:2),
                 new Resource(Rarity: Rarity.Legendary, Material:materialRandom,  Category: Category.Resource, Price:100, Quantity:2),
                 new Resource(Rarity: Rarity.Legendary, Material:materialRandom,  Category: Category.Resource, Price:100, Quantity:2),

            };

            Sword sword = new Sword(Quantity: worldItems.ElementAt(0).Quantity, Damage: 1000, Resource:(Resource)worldItems.ElementAt(0), Rarity:Rarity.Legendary);
            worldItems.Add(sword);
            sword.DisplaySword();

            Shield shield = new Shield(Name:"Somshield", Category:Category.Shield, Price:777, Quantity: worldItems.ElementAt(1).Quantity, Protection:500, Resource:(Resource)worldItems.ElementAt(1), Rarity:Rarity.Common );
            shield.DisplayShield();

            Resource gold = new Resource(Rarity: Rarity.Legendary, Material: Material.Gold, Category: Category.Resource, Price: 100, Quantity: 2);
            gold.DisplayResource();


        }
    }
}
