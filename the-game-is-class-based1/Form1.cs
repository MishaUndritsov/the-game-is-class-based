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
        Character paladin1 = new paladin(800, 400, 80);
        Character Preast1 = new Preast(400, 900, 300);
        Character Shaman1 = new Shaman(500, 70, 50);
        Character Rogue1 = new Rogue(360, 500, 100);
        Character paladin2 = new paladin(800, 400, 80);
        Character Preast2 = new Preast(400, 900, 300);
        Character Shaman2 = new Shaman(900, 700, 50);
        Character Rogue2 = new Rogue(360, 500, 100);
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text= "HP = " + paladin1.Hp.ToString();
            label2.Text = "MP = " + paladin1.Mp.ToString();
            label3.Text = "HP = " + Shaman1.Hp.ToString();
            label4.Text = "MP = " + Shaman1.Mp.ToString();
            label5.Text = "MP = " + Preast1.Hp.ToString();
            label6.Text = "MP = " + Preast1.Mp.ToString();
            label7.Text = "MP = " + Rogue1.Hp.ToString();
            label8.Text = "MP = " + Rogue1.Hp.ToString();

            label9.Text = "MP = " + paladin2.Hp.ToString();
            label10.Text = "MP = " + paladin2.Mp.ToString();
            label11.Text = "MP = " + Shaman2.Hp.ToString();
            label12.Text = "MP = " + Shaman2.Mp.ToString();
            label13.Text = "MP = " + Preast2.Hp.ToString();
            label14.Text = "MP = " + Preast2.Mp.ToString();
            label15.Text = "MP = " + Rogue2.Hp.ToString();
            label16.Text = "MP = " + Rogue2.Hp.ToString();
            
           
        }

        

        

      

      
    }
}
