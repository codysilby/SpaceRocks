using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Reflection;
using System.Threading.Tasks;

namespace SpaceRocks
{
    class Rock
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image rockImage;//variable for the planet's image

        public Rectangle rockRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Rock(int spacing)
        {
            y = spacing;
            x = 10;
            width = 55;
            height = 55;
            rockImage = Image.FromFile("rock1.png");
            rockRec = new Rectangle(x, y, width, height);
        }
        // Methods for the Planet class
        public void drawRock(Graphics g)
        {
            rockRec = new Rectangle(x, y, width, height);
            g.DrawImage(rockImage, rockRec);
        }
        public void moveRock()
        {
            rockRec.Location = new Point(x, y);
            if (rockRec.Location.X > 740)
            {
                score += 1;//This will add 1 point to the player's score when the planet reaches the bottom of the game panel.
                x = -60;
                rockRec.Location = new Point(x, y);
            }

        }


    }
}
