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
        public float Health
        {
            get => health;
            
            set 
            {
                if (value < 0)
                {
                    health = 0;
                }
                else if (value > MaxHealth)
                {
                    health = MaxHealth;
                }
                else
                {
                    health = value;
                }
            }
        }
        public void TakeDamage(float damage)
        {
            health -= damage;
            xp += (int)(damage / 20);
        }
    }
}