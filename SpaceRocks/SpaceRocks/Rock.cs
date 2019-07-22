using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
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
        public Rock()
        {
            x = 10;
            y = 10;
            width = 20;
            height = 20;
            rockImage = Image.FromFile("rock1.png");
            rockRec = new Rectangle(x, y, width, height);
        }

    }
}
