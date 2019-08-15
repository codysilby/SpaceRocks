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
        Rocket rocket = new Rocket();
        bool left, right;
        int score, lives;
        string move;



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
           // MessageBox.Show("Use the left and right arrow keys to move your space rocket! \n Don't get hit by the SpaceRocks! \n Every SpaceRock that gets past scores a point. \n If a SpaceRock hits your space rocket a life is lost! \n \n Enter your Name press tab and enter the number of lives \n Click Start to begin", "Game Instructions");
            txtName.Focus();
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
            rocket.drawRocket(g);
        }

        private void frmRocks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
        }

        private void frmRocks_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
        }

        private void tmrRocket_Tick(object sender, EventArgs e)
        {
            if (right) // if right arrow key pressed
            {
                move = "right";
                rocket.moveRocket(move);
            }
            if (left) // if left arrow key pressed
            {
                move = "left";
                rocket.moveRocket(move);
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;
            startLogo.Visible = false;
            score = 0;
            lblScore.Text = score.ToString();
            lives = int.Parse(lblLives.Text);// pass lives entered from textbox to lives variable
            tmrRock.Enabled = true;
            tmrRocket.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrRocket.Enabled = false;
            tmrRock.Enabled = false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tmrRock_Tick(object sender, EventArgs e)
        {
            score = 0;
            for (int i = 0; i < 7; i++)
            {
                rock[i].moveRock();
                if (rocket.rocketRec.IntersectsWith(rock[i].rockRec))
                {
                    //reset planet[i] back to top of panel
                    rock[i].y = 30; // set  y value of planetRec
                    lives -= 1;// lose a life
                    lblLives.Text = lives.ToString();// display number of lives
                    checkLives();
                }
                score += rock[i].score;// get score from Planet class (in movePlanet method)
                lblScore.Text = score.ToString();// display score
            }
            pnlGame.Invalidate();//makes the paint event fire to redraw the panel

        }
        private void checkLives()
        {
            if (lives == 0)
            {
                tmrRock.Enabled = false;
                tmrRocket.Enabled = false;
                MessageBox.Show("Oops! Better luck next time.");

            }
        }

    }
}
