using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestClassi
{
    public partial class Form1 : Form
    {
        private List<Monster> monsters;

        public Form1()
        {
            InitializeComponent();
            monsters = Deserialiser.deserialiseMonsters();

            /* foreach (Monster m in monsters)
            {
                Console.WriteLine(m.GetType());
                if (m.GetType() == typeof(Fire_Monster))
                {
                    Fire_Monster f = m as Fire_Monster;
                    Console.WriteLine(f.fireDamage);
                }
            } */
        }

        private int currentMonsterIndex = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            renderMonster(currentMonsterIndex);
        }

        private Monster addMonster (Monster m)
        {
            monsters.Add(m);
            return m;
        } 

        private void renderMonster(int monsterIndex)
        {
            enemyImg.Image = monsters[monsterIndex].image;
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (currentMonsterIndex == 0) return;
            currentMonsterIndex--;
            renderMonster(currentMonsterIndex);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentMonsterIndex == monsters.Count - 1) return;
            currentMonsterIndex++;
            renderMonster(currentMonsterIndex);
        }
    }
}
