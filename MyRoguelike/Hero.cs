using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRoguelike
{
    public class Hero
    {
        private int xp;
        private float health;
        public Hero (string name)
        {
            Name = name;
            health = MaxHealth;
            xp = 0;
        }
        public string Name { get; private set; }
        public int Level => 1 + xp / 1000;
        public int XP
        {
            get => xp;
            set
            {
            if (value > xp)
                {
                    xp = value;
                }
            }
            
        }        
        public float MaxHealth => 100 + (Level -1) * 20;
        public float Health()
        {
            if (health < 0)
            {
                return health = 0;
            }
            if (health > MaxHealth)
            {
                return health = MaxHealth;
            }
            else
            {
                return health;
            }
        }
        public void TakeDamage(float damage)
        {
            health -= damage;
            xp += (int)(damage / 20);
        }
    }
}