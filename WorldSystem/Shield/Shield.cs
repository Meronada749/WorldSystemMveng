/*
Entreprise : ETML
Auteur : Meron Essayas
Date : 24.01.2025
Description : 
*/

using System;
using static System.Net.Mime.MediaTypeNames;

namespace WorldSystem
{
    internal class Shield : IShield
    {
        public Rarity Rarity { get; private set; }
        public Category Category { get; private set; } = Category.Shield;
        public int ShieldPrice { get; private set; }
        public int Quantity { get; private set; }
        public int Protection { get; private set; }
        public Resource Resource { get; private set; }
        public ShieldName ShieldName { get; private set; }

        public Shield(int Quantity, Resource Resource, Rarity Rarity) 
        {
            ShieldName = GetRandomShieldName();
            this.Quantity = Quantity;
            this.Resource = Resource;
            this.Rarity = Rarity;
            switch (ShieldName)
            {
                case ShieldName.Banner_of_the_Fallen:
                    ShieldPrice = 10000;
                    Protection = 1;
                    break;
                case ShieldName.Bulwark_of_Azzinoth:
                    ShieldPrice = 1000;
                    Protection = 2;
                    break;
                case ShieldName.Shield_of_the_Righteous:
                    ShieldPrice = 8000;
                    Protection = 3;
                    break;
                case ShieldName.Aegis_of_the_Scarlet_Crusade:
                    ShieldPrice = 7000;
                    Protection = 5;
                    break;
                case ShieldName.The_Shield_of_the_Eternal_Champion:
                    ShieldPrice = 5000;
                    Protection = 6;
                    break;
                default:
                    break;
            }
        }

        public void DisplayShield()
        {
            Console.WriteLine($"The {Category}'s name is {ShieldName}, protection is {Protection}. It is {Rarity}, made of {Resource.MaterialWithWeight}, it costs {ShieldPrice}.\n");
        }

        public ShieldName GetRandomShieldName()
        {
            Random random = new Random();
            Array shieldNames = Enum.GetValues(typeof(ShieldName));
            return (ShieldName)shieldNames.GetValue(random.Next(shieldNames.Length));
        }
        public string ToCsvLine()
        {
            return $"{Category},{Resource},{Quantity}";
        }
    }
}
