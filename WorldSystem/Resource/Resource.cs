/*
Entreprise : ETML
Auteur : Meron Essayas
Date : 24.01.2025
Description : 
*/

using System;


namespace WorldSystem
{
    internal class Resource : IResource 
    {
        public Category Category { get; private set; } = Category.Resource;
        public Rarity Rarity { get; private set; }
        public MaterialWithWeight MaterialWithWeight { get; private set; }
        public MaterialWithPrice MaterialWithPrice { get; private set; }
        public int Quantity { get; private set; }
        public int Weight { get; private set; }

        public Resource(Rarity Rarity, MaterialWithWeight MaterialWithWeight, MaterialWithPrice MaterialWithPrice, int Quantity) 
        { 
            this.Rarity = Rarity;
            this.MaterialWithWeight = MaterialWithWeight;
            this.MaterialWithPrice = MaterialWithPrice;
            this.Quantity = Quantity;
            this.Weight = (int)MaterialWithWeight * Quantity;
        }
        public void DisplayResource()
        {
            Console.WriteLine($"The {Category} is {MaterialWithWeight}, it is {Rarity}, it weighs {Weight} kilos and costs {MaterialWithPrice} for {Quantity}.\n");
        }

        public string ToCsvLine()
        {
            return $"{Category},{Rarity},{MaterialWithWeight},{MaterialWithPrice},{Quantity}";
        }
    }
}
