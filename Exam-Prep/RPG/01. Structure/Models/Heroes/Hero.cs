using System;
using System.Collections.Generic;
using System.Text;
using Heroes.Models.Contracts;

namespace Heroes.Models.Heroes
{
    public abstract class Hero : IHero
    {

        private string name;
        private int health;
        private int armour;
        private IWeapon weapon;

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Hero name cannot be null or empty.");
                }
                this.name = value;
            }
        }

        public int Health
        {
            get => this.health;
            private set
            {
                if (value<0)
                {
                    throw new ArgumentException("Hero health cannot be null or empty.");
                }
                this.health = value;
            }
        }

        public int Armour
        {
            get => this.armour;
            private set
            {
                if (value<0)
                {
                    throw new ArgumentException("Hero armour cannot be null or empty.");
                }
                this.armour = value;
            }
        }

        public IWeapon Weapon
        {
            get => this.weapon;
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Weapon cannot be null.");
                }
                this.weapon = value;
            }
        }

        protected Hero(string name,int health,int armour)
        {
            this.Name = name;
            this.Health = health;
            this.Armour = armour;
        }

        public bool IsAlive => this.Health > 0;

        public void AddWeapon(IWeapon weapon) => this.Weapon = weapon;

        public void TakeDamage(int points)
        {
            var ArmourLeft = this.Armour - points;
            if (ArmourLeft < 0)
            {
                this.Armour = 0;
                var damage = -ArmourLeft;
              var HealthLeft = this.Health - damage;
                if (HealthLeft < 0)
                {
                    this.Health = 0;
                }
                else
                {
                    this.Health = HealthLeft;
                }
            }
            else
            {
                this.Armour = ArmourLeft;
            }
        }
    }
}
