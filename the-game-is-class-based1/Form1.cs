using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApplication1;

namespace the_game_is_class_based1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Character paladin1 = new paladin(800, 400, 80);
            Character Preast1 = new Preast(400, 900, 300);
            Character Shaman1 = new Shaman(500, 70, 50);
            Character Rogue1 = new Rogue(360, 500, 100);
            Character paladin2 = new paladin(800, 400, 80);
            Character Preast2 = new Preast(400, 900, 300);
            Character Shaman2 = new Shaman(900, 700, 50);
            Character Rogue2 = new Rogue(360, 500, 100);
        }
    }
}
