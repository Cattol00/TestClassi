using System;
using System.Windows.Forms;
using System.Drawing;

namespace TestClassi
{
    class Monster
    {
        private string _name;
        public string name { get { return _name; } }
        
        private int _maxHp;
        public int maxHp { get { return _maxHp; } }
        
        private int _currentHp;
        public int currentHp
        {
            set
            {
                if (value < 0) value = 0;
                else if (value > _maxHp) value = _maxHp;
                _currentHp = value;
            }
            get
            {
                return _currentHp;
            }
        }

        private int _damage;
        public int damage { get { return _damage; } }
        
        private int _healFactor;
        public int healFactor { get { return _healFactor; } }
       
        public bool alive { get { return currentHp > 0; } }
        
        public string status
        {
            get
            {
                return currentHp + " / " + maxHp + " HP";
            }
        }

        public Image image { get; set; }

        public Monster(string name, int maxHp, int damage, int healFactor = 0)  //parametro opzionale
        {
            _name = name;

            image = Image.FromFile(Assets.getImagePath(name));

            if (maxHp < 1) maxHp = 1;
            _maxHp = maxHp;

            currentHp = maxHp;

            if (damage < 0) damage = 0;
            _damage = damage;

            if (healFactor < 0) healFactor = 0;
            _healFactor = healFactor;

            describe();
        }

        public string describe()
        {
            string output = "Questo è " + name + "\r\n" + "\r\n";
            output += "HP: " + currentHp + "\r\n";
            output += "DAMAGE: " + damage + "\r\n";
            output += "HEAL FACTOR: " + healFactor + "\r\n";
            
            return output;
        }

        public void describe(TextBox t)
        {
            t.Text = describe();
        }

        public virtual void attack(Monster target)
        {
            if (!target.alive)
            {
                Console.WriteLine(target.name + " è già stato sconfitto, non infierire.");
                return;
            }

            if (!alive)
            {
                Console.WriteLine("Sei morto, non puoi attaccare nessuno.");
                return;
            }

            Console.WriteLine(name + " attacca " + target.name + " e gli infligge " + damage + " danni.");
            target.currentHp -= damage;
            
            if (!target.alive)
            {
                Console.WriteLine(target.name + " è stato sconfitto.");
            }
            else
            {
                Console.WriteLine("A " + target.name + " rimangono " + target.status);
            }
        }

        public void heal()
        {
            heal(this);
        }

        public void heal(Monster target)
        {
            if (target.currentHp == target.maxHp)
            {
                Console.WriteLine("La salute del mostro che vuoi curare è già al massimo.");
                return;
            }

            if (!target.alive)
            {
                Console.WriteLine("Il mostro che vuoi curare è morto, non puoi curarlo.");
                return;
            }

            if (healFactor == 0) 
            {
                Console.WriteLine("Non hai potere di cura.");
                return;
            }

            if (!alive)
            {
                Console.WriteLine("Non puoi curare da morto.");
                return;
            }

            target.currentHp += healFactor;

            Console.WriteLine("Il mostro " + target.name + " è stato curato e ora ha " + target.status); 
        }
    }
}