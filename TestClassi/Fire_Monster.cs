﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TestClassi
{
    class Fire_Monster: Monster 
    {
        public int fireDamage { get; set; }
        public Fire_Monster(string name, int maxHp, int damage, int fireDamage) : base(name, maxHp, damage, 0)
        {
            this.fireDamage = fireDamage;
        }

        public override void attack(Monster target)
        {
            base.attack(target);

            if (alive && target.alive)
            {
                Console.WriteLine("Infliggi ulteriori " + fireDamage + "danni da fuoco a " + target.name);
                target.currentHp -= fireDamage;
                Console.WriteLine(target.name + "rimane con " + target.status);
            } 
        } 
    }
}
