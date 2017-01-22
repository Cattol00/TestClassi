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
        public Form1()
        {
            InitializeComponent();
        }

        private List<Monster> monsters = new List<Monster>();

        private Monster addMonster (Monster m)
        {
            monsters.Add(m);
            return m;
        }
           
        private void Form1_Load(object sender, EventArgs e)
        {
            Monster carrapax = new Monster("Carrapax", 100, 15, 10);
            Monster kolossus = new Monster("Kolossus", 80, 30, 5);
            carrapax.describe(textBox1);
            kolossus.describe(textBox2);
        }
    }
}
