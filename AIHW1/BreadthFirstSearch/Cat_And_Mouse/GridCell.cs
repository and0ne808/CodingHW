using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Threading;

namespace AI_HW
{
    class GridCell : DrawableGameComponent
    {
        public int x;
        public int y;
        public int width;
        public int height;
        public Color color;


        public GridCell(Game game)
            : base(game)
        {
            x = 0;
            y = 0;
            width = 0;
            height = 0;
            color = Color.CornflowerBlue;
        }

        public void setLocation(int newX, int newY)
        {
            x = newX;
            y = newY;
        }
        public void setSize(int newWidth, int newHeight)
        {
            width = newWidth;
            height = newHeight;
        }
        public void setColor(Color newColor)
        {
            color = newColor;
        }


        public void draw(SpriteBatch spriteBatch, GraphicsDeviceManager graphics)
        {
            Primitives2D.FillRectangle(spriteBatch, new Rectangle(x, y, width, height), color);
            Primitives2D.DrawRectangle(spriteBatch, new Rectangle(x, y, width, height), Color.Black);
        }
    }
}
