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
        bool left, right, up, down;
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
                rock[i].y = yspeed.Next(-300, 0);
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
            if (e.KeyData == Keys.Up) { up = true; }
            if (e.KeyData == Keys.Down) { down = true; }
        }

        private void frmRocks_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
            if (e.KeyData == Keys.Up) { up = false; }
            if (e.KeyData == Keys.Down) { down = false; }
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
            if (up) // if up arrow key pressed
            {
                move = "up";
                rocket.moveRocket(move);
            }
            if (down) // if down arrow key pressed
            {
                move = "down";
                rocket.moveRocket(move);
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;
            startLogo.Visible = false;
            score = 0;
            lblScore.Text = score.ToString();
            lives = int.Parse(txtLives.Text);// pass lives entered in the start screen textbox to lives variable
            lblLives.Text = txtLives.Text;//updates the label on the game panel to display the lives which were entered in the start screen
            lblName.Text = txtName.Text;//updates the name label on the game panel to display the name which was entered on start
            tmrRock.Enabled = true;//enables the Rocks to move
            tmrRocket.Enabled = true;//enables the rocket to be able to move
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrRocket.Enabled = false;
            tmrRock.Enabled = false;
        }

        private void txtName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)//makes it so only letters can be entered into textbox for name at start screen
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtLives_KeyPress(object sender, KeyPressEventArgs e)//makes it so only numbers can be entered into lives textbox
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
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
                    //reset spacerock[i] back to top of panel
                    rock[i].y = -60; // set  y value of rockRec
                    lives -= 1;// takes 1 life off 
                    lblLives.Text = lives.ToString();// displays the number of lives 
                    checkLives();
                }
                score += rock[i].score;// get score from Rock class (in the moveRock method)
                lblScore.Text = score.ToString();// displays the score
            }
            pnlGame.Invalidate();//makes the panel redraw - invalidates the panel so the paint fire even redraws the panel

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
