using System;
using System.Collections.Generic;
using System.Text;
using Heroes.Models.Contracts;

namespace Heroes.Models
{
    public abstract class Weapon : IWeapon
    {
        private string name;
        private int durability;
        private int damage;

        protected Weapon(string name,int durability,int damage)
        {
            this.Name = name;
            this.Durability = durability;
            this.Damage = damage;
        }
        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Weapon type cannot be null or empty.");
                }
                this.name = value;
            }
        }

        public int Durability
        {
            get => this.durability;
            private set
            {
                if (value<0)
                {
                    throw new ArgumentException("Durability cannot be below 0.");
                }
                this.durability = value;
            }
        }
        private int Damage
        {
            get => this.damage;
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Damage cannot be below 0.");
                }
            }
        }


        public int DoDamage()
        {
            this.Durability--;

            if (this.Durability == 0)
            {
                return 0;
            }
            return this.Damage;
        }

    }
}
