using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace SpaceRocks
{
    class Rocket
    {
        // declare fields to use in the class

        public int x, y, width, height;//variables for the rectangle
        public Image rocket;//variable for the planet's image

        public Rectangle rocketRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Rocket()
        {
            x = 10;
            y = 360;
            width = 40;
            height = 80;
            rocket = Image.FromFile("ship1.png");
            rocketRec = new Rectangle(x, y, width, height);
        }
        //methods
        public void drawRocket(Graphics g)
        {

            g.DrawImage(rocket, rocketRec);
        }

        public void moveRocket(string move)
        {
            rocketRec.Location = new Point(x, y);

            if (move == "right")
            {
                if (rocketRec.Location.X > 700) // is rocket within 50 of right side
                {

                    x = 700;
                    rocketRec.Location = new Point(x, y);
                }
                else
                {
                    x += 5;
                    rocketRec.Location = new Point(x, y);
                }

            }

            if (move == "left")
            {
                if (rocketRec.Location.X < 10) // is spaceship within 10 of left side
                {

                    x = 10;
                    rocketRec.Location = new Point(x, y);
                }
                else
                {
                    x -= 5;//speed of rocket moving left
                    rocketRec.Location = new Point(x, y);
                }

            }



        }


    }
}
