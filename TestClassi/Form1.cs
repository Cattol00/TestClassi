﻿using System;
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
            listView1.Items.Add(new ListViewItem("prova"));
            listView1.Items.Add("CIAO");

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
            renderMonster(monsters[currentMonsterIndex]);
            renderMonster(monsters[0], false);
        }

        private Monster addMonster (Monster m)
        {
            monsters.Add(m);
            return m;
        } 

        private void renderMonster(Monster m, bool isPlayer = true)
        {
            if (isPlayer)
            {
                pNameLbl.Text = m.name;
                pHpLbl.Text = m.status;
                pHpBar.Maximum = m.maxHp;
                pHpBar.Value = m.currentHp;
                pPicture.Image = m.image;
            }
            else
            {
                eNameLbl.Text = m.name;
                eHpLbl.Text = m.status;
                eHpBar.Maximum = m.maxHp;
                eHpBar.Value = m.currentHp;
                ePicture.Image = m.image;
            }
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (currentMonsterIndex == 0) return;
            currentMonsterIndex--;
            renderMonster(monsters[currentMonsterIndex]);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentMonsterIndex == monsters.Count - 1) return;
            currentMonsterIndex++;
            renderMonster(monsters[currentMonsterIndex]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logs.Items.Add(eNameLbl.Text + " ha attaccato " + pNameLbl.Text);
            Monster m = monsters[currentMonsterIndex];
            m.currentHp -= 20;
            renderMonster(m);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
