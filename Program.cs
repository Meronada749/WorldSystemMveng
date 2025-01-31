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
            
            Resource gold = new Resource(Rarity: Rarity.Legendary, Weight:55, Material:Material.Gold,  Category: Category.Resource, Price:100, Quantity:2);
            //gold.Display();
            Random random = new Random();

            Array mat = Enum.GetValues(typeof(Material));
            Material materialRandom = (Material)mat.GetValue(random.Next(mat.Length));

            List<IItem> worldItems = new List<IItem>()
            {
                 new Resource(Rarity: Rarity.Legendary, Weight:random.Next(1,10), Material:materialRandom,  Category: Category.Resource, Price:100, Quantity:2),
                 new Resource(Rarity: Rarity.Legendary, 55, Material:Material.Diamond,  Category: Category.Resource, 100, 2),
                 new Resource(Rarity: Rarity.Legendary, 55, Material:Material.Iron,  Category: Category.Resource, 100, 2),
                 gold,
                 
            };
            Sword sword = new Sword(Name: "Nelsonator", Category.Sword, Price: 42000, Quantity: worldItems.ElementAt(0).Quantity, Damage: 1000, Resource: (Resource)worldItems.ElementAt(0), Rarity:Rarity.Legendary);
            worldItems.Add(sword);
            sword.DisplaySword();

            Shield shield = new Shield(Name:"Somshield", Category.Shield, Price:777, Quantity:100, Protection:500, Resource: gold, Rarity:Rarity.Common );
            shield.DisplayShield();


        }
    }
}
