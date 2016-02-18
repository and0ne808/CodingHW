using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Cat_And_Mouse
{
    /// <summary>
    /// Renders a sprite
    /// </summary>
    public abstract class Sprite : DrawableGameComponent
    {
        public float x; // x position on the screen
        public float y; // y position on the screen
        public float rot; // rotation angle
        public float rot_vel; //rotational velocity
        public float rot_accel; //rotational acceleration

        public float vel_x; // velocity in the x direction
        public float vel_y; // velocity in the y direction
        public float max_vel = 10; // max velocity
        public float accel_x; //acceleration
        public float accel_y; //acceleration
        public float accel_rate;
        public float friction;

        public Texture2D tex; // the texture of the sprite

        protected String fileName; // the name of the file to take the sprite from

        protected Game currentGame;

        public Sprite(Game game)
            : base(game)
        {
            currentGame = game;
        }
        /*
        public Sprite(Game game, String spriteName)
            :base(game)
        {

        }
        */

        public void randomizePosition()
        {
            Random rand1 = new Random();
            Random rand2 = new Random();
            int newX = rand1.Next(1024);
            int newY = rand2.Next(768);
            x = newX;
            y = newY;
        }

        public void setTex(String filename)
        {
            tex = currentGame.Content.Load<Texture2D>(filename);
        }

        public void draw(SpriteBatch spriteBatch, GraphicsDeviceManager graphics)
        {
            spriteBatch.Draw(tex, new Rectangle((int)x - tex.Width / 2, (int)y - tex.Width / 2, tex.Width, tex.Height), new Rectangle(0, 0, tex.Width, tex.Height), Color.White, rot, new Vector2(tex.Width/2,tex.Height/2), SpriteEffects.None, 0);
        }


    }
}
