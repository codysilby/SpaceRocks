using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace SpaceRocks
{
    public partial class frmRocks : Form
    {
        Graphics g; //declare a graphics object called g
        Rock[] rock = new Rock[7];
        Random yspeed = new Random();
        public frmRocks()
        
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, pnlGame, new object[] { true });
            for (int i = 0; i < 7; i++)
            {
                int x = 10 + (i * 115);
                rock[i] = new Rock(x);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmRocks_Load(object sender, EventArgs e)
        {

        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Planet class's DrawPlanet method to draw the image planet1 
            for (int i = 0; i < 7; i++)
            {
                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = yspeed.Next(5, 20);
                rock[i].y += rndmspeed;

                //call the Planet class's drawPlanet method to draw the images
                rock[i].drawRock(g);
            }

        }

        private void tmrRock_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                rock[i].moveRock();
            }
            pnlGame.Invalidate();//makes the paint event fire to redraw the panel

        }
    }
}
