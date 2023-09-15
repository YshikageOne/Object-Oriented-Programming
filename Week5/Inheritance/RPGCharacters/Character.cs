using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Inheritance.RPGCharacters
{
    public class Character
    {
        private int health;
        private int damage;
        private int shield;

        public Character(int health, int damage, int shield)
        {
            this.health = health;
            this.damage = damage;
            this.shield = shield;
        }

        //Getters
        public int GetHealth() { return health; }
        public int GetDamage() { return damage; }
        public int GetShield() {  return shield; }

        //Setters
        public void SetHealth(int health)
        {
            this.health = health;
        }

        public virtual void ReceiveDamage(int damage)
        {
            health -= (damage - shield);

            if(health <= 0)
            {
                Console.WriteLine("Character has died");
            }
        }
    }
}
