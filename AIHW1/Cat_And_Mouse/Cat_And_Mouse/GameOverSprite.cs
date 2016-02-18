using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Cat_And_Mouse
{
    class GameOverSprite: Sprite
    {
        public GameOverSprite(Game game)
            : base (game)
        {

        }
        public void draw(SpriteBatch spriteBatch, GraphicsDeviceManager graphics)
        {
            spriteBatch.Draw(tex, new Rectangle(0, 0, tex.Width, tex.Height), new Rectangle(0, 0, tex.Width, tex.Height), Color.White, rot, Vector2.Zero, SpriteEffects.None, 0);
        }

    }
}
