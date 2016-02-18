using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Cat_And_Mouse
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        static public bool catWins = false;
        static public bool mouseWins = false;
        bool isTimerOn = true;
        static public float counter = 30000;

        UserSprite mouseSprite;
        AgentSprite catSprite;
        GameOverSprite catWin;
        GameOverSprite mouseWin;




        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = 1024;
            graphics.PreferredBackBufferHeight = 768;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            mouseSprite = new UserSprite(this);
            catSprite = new AgentSprite(this);
            catWin = new GameOverSprite(this);
            mouseWin = new GameOverSprite(this);

            mouseSprite.randomizePosition();
            catSprite.randomizePosition();
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            mouseSprite.setTex("mouse");
            catSprite.setTex("cat");
            mouseWin.setTex("mousewin");
            catWin.setTex("catwin");
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            mouseSprite.update();
            catSprite.update(gameTime, mouseSprite.x + 16, mouseSprite.y + 16);

            // TODO: Add your update logic here
            if (isTimerOn)
            {
                counter -= gameTime.ElapsedGameTime.Milliseconds;
                if (counter <= 0)
                {
                    mouseWins = true;
                    catWins = false;
                }
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();

            mouseSprite.draw(spriteBatch, graphics);
            catSprite.draw(spriteBatch, graphics);

            
          if (mouseWins)
            {
                mouseWin.draw(spriteBatch, graphics);
            }
          else if (catWins)
            {
                catWin.draw(spriteBatch, graphics);
            }
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
