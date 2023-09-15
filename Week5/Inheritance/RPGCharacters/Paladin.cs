using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Inheritance.RPGCharacters
{
    public class Paladin : Swordsman
    {
        private bool hasResurrected;

        public Paladin() : base()
        {
            hasResurrected = false;
        }

        public override void ReceiveDamage(int damage)
        {
            if(damage % 2 == 0)
            {
                damage /= 2;
            }

            base.ReceiveDamage(damage);

            if(GetHealth() <= 0)
            {
                Resurrect();
            }
        }

        public void Resurrect()
        {
            if(!hasResurrected)
            {
                hasResurrected = true;
                SetHealth(100);
            }
            else
            {
                Console.WriteLine("Paladin has died");
            }
        }
    }
}
