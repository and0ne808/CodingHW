using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Cat_And_Mouse
{
    class Bar : Sprite
    {
        //public static float currentPercentage;
        Sprite m_host;

        public Bar(Game game, Sprite host)
            : base(game)
        {
            currentGame = game;
            //currentPercentage = 0;
            m_host = host;
        }
        public void update(GameTime gameTime)
        {
            //Position the bar
            x = m_host.x - m_host.tex.Width * 2;
            y = m_host.y - m_host.tex.Height * 2;
            //x = 100;
            //y = 100;
        }
        public void draw(SpriteBatch spriteBatch, GraphicsDeviceManager graphics)
        {
            spriteBatch.Draw(tex, new Rectangle((int)x + (int)100 / 2, (int)y, (int)100, tex.Height), new Rectangle(0, 0, tex.Width, tex.Height), Color.White, rot, new Vector2(tex.Width / 2, tex.Height / 2), SpriteEffects.None, 0);
        }
    }
}
