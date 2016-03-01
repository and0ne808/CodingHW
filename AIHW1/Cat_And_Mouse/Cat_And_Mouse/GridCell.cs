using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Threading;

namespace Cat_And_Mouse
{
    class GridCell : DrawableGameComponent
    {
        public int cellSize;
        public int x;
        public int y;
        public int width;
        public int height;


        public GridCell(Game game)
            : base(game)
        {
            x = 0;
            y = 0;
            width = 0;
            height = 0;
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


        public void draw(SpriteBatch spriteBatch, GraphicsDeviceManager graphics)
        {
            Primitives2D.FillRectangle(spriteBatch, new Rectangle(x, y, width, height), Color.Gray);
            Primitives2D.DrawRectangle(spriteBatch, new Rectangle(x, y, width, height), Color.Yellow);
        }
    }
}
