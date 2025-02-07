/*
Entreprise : ETML
Auteur : Meron Essayas
Date : 24.01.2025
Description : 
*/
using WorldSystem;
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

            Array rarity = Enum.GetValues(typeof(Rarity));
            Rarity RarityRandom = (Rarity)rarity.GetValue(random.Next(rarity.Length));

            Array materialWeight = Enum.GetValues(typeof(MaterialWithWeight));
            MaterialWithWeight MaterialWeightRandom = (MaterialWithWeight)materialWeight.GetValue(random.Next(materialWeight.Length));

            Array materialPrice = Enum.GetValues(typeof(MaterialWithPrice));
            MaterialWithPrice MaterialPriceRandom = (MaterialWithPrice)materialPrice.GetValue(random.Next(materialPrice.Length));

            List<IItem> worldItems = new List<IItem>()
            {
                 new Resource(Rarity:Rarity.Legendary, MaterialWithWeight:MaterialWeightRandom, MaterialWithPrice:MaterialPriceRandom, Quantity:2),
                 new Resource(Rarity:Rarity.Legendary, MaterialWithWeight:MaterialWeightRandom, MaterialWithPrice:MaterialPriceRandom, Quantity:1),
                 new Resource(Rarity:Rarity.Legendary, MaterialWithWeight:MaterialWeightRandom, MaterialWithPrice:MaterialPriceRandom, Quantity:3),
            };

            Sword sword = new Sword(Quantity:worldItems.ElementAt(0).Quantity, Resource:(Resource)worldItems.ElementAt(0), Rarity:RarityRandom);
            //worldItems.Add(sword);
            sword.DisplaySword();

            Shield shield = new Shield(Quantity:worldItems.ElementAt(1).Quantity, Resource:(Resource)worldItems.ElementAt(1), Rarity:RarityRandom);
            shield.DisplayShield();

            Resource gold = new Resource(Rarity:RarityRandom, MaterialWithWeight: MaterialWeightRandom, MaterialWithPrice: MaterialPriceRandom, Quantity:2);
            gold.DisplayResource();
        }
    }
}
