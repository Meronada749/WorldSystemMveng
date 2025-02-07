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
    internal class Sword : ISword
    {
        public Rarity Rarity { get; private set; }
        public Category Category { get; private set; } = Category.Sword;
        public int SwordPrice { get; private set; }
        public int Quantity { get; private set; }
        public int Damage { get; private set; }
        public Resource Resource { get; private set; }
        public SwordName SwordName { get; private set; }

        public Sword(int Quantity, Resource Resource, Rarity Rarity)
        {
            SwordName = GetRandomSwordName();
            this.Quantity = Quantity;
            this.Resource = Resource;
            this.Rarity = Rarity;
            switch (SwordName)
            {
                case SwordName.The_Sword_of_a_Thousand_Truths:
                    SwordPrice = 10000;
                    Damage = 1;
                    break;
                case SwordName.Ashbringer:
                    SwordPrice = 1000;
                    Damage = 2;
                    break;
                case SwordName.Excalibur:
                    SwordPrice = 8000;
                    Damage = 3;
                    break;
                case SwordName.The_Zulqifar:
                    SwordPrice = 7000;
                    Damage = 5;
                    break;
                case SwordName.Warglaives_of_Azzinoth:
                    SwordPrice = 5000;
                    Damage = 6;
                    break;
                default:
                    break;
            }
        }

        public void DisplaySword()
        {
            Console.WriteLine($"The {Category}'s name is {SwordName}, damage is {Damage}. It is {Rarity}, made of {Resource.MaterialWithWeight}, it costs {SwordPrice}.\n");
        }

        public SwordName GetRandomSwordName()
        {
            Random random = new Random();
            Array swordNames = Enum.GetValues(typeof(SwordName));
            return (SwordName)swordNames.GetValue(random.Next(swordNames.Length));
        }
        public string ToCsvLine()
        {
            return $"{Category},{Resource},{Quantity}";
        }
    }
}
