using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Text;

namespace Cat_And_Mouse
{
    public class UserSprite : Sprite  
    {
       // public static float x;
      //  public static float y;
        public int moveSpeed = 3;
        protected bool readytojump = true;
        protected const float DEGREES_TO_RADS = 0.01745f;

        public UserSprite(Game game)
            : base(game)
        {

        }
        public void update()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                y += moveSpeed;
                rot = 90 * DEGREES_TO_RADS;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                y -= moveSpeed;
                rot = -90 * DEGREES_TO_RADS;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                x -= moveSpeed;
                rot = 180 * DEGREES_TO_RADS;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                x += moveSpeed;
                rot = 0;
            }
            /*
            else if (Keyboard.GetState().IsKeyDown(Keys.W) && Keyboard.GetState().IsKeyDown(Keys.A)) //north west (broken)
            {
                y -= (moveSpeed * 0.3535f);
                x -= (moveSpeed * 0.3535f);
            }
            */

            if (Keyboard.GetState().IsKeyUp(Keys.Space) && !readytojump)
            {
                readytojump = true;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Space) && readytojump)
            {


                if(Game1.catWins)
                {
                    Game1.catWins = false;
                    Game1.counter = 30000;
                    JumpBar.currentPercentage = 100;
                }
                if(Game1.mouseWins)
                {
                    Game1.mouseWins = false;
                    Game1.counter = 30000;
                    JumpBar.currentPercentage = 100;
                }

                if (JumpBar.currentPercentage == 100)
                {
                    Random rand = new Random();
                    int newX = rand.Next(1024);
                    int newY = rand.Next(768);
                    x = newX;
                    y = newY;
                    readytojump = false;
                    Game1.jumpCounter = 5000;
                }

            }
        }
    }
}
