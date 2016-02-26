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
        static public float jumpCounter = 5000;

        UserSprite mouseSprite;
        AgentSprite catSprite;
        TankSprite tankSprite;
        CarSprite carSprite;
        GameOverSprite catWin;
        GameOverSprite mouseWin;
        SpriteFont myFont;
        JumpBar jumpBar;
        




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
            carSprite = new CarSprite(this);
            tankSprite = new TankSprite(this);
            catWin = new GameOverSprite(this);
            mouseWin = new GameOverSprite(this);
            jumpBar = new JumpBar(this, mouseSprite);

            mouseSprite.randomizePosition();
            catSprite.randomizePosition();
            carSprite.randomizePosition();
            tankSprite.randomizePosition();
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
            carSprite.setTex("car");
            tankSprite.setTex("tank");
            mouseWin.setTex("mousewin");
            catWin.setTex("catwin");
            jumpBar.setTex("bar");

            myFont = Content.Load<SpriteFont>("andrewFont");
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
            carSprite.update(gameTime, mouseSprite.x + 16, mouseSprite.y + 16);
            tankSprite.update(gameTime, mouseSprite.x + 16, mouseSprite.y + 16);
            jumpBar.update(gameTime);

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

            if(jumpCounter > 0)
            {
                jumpCounter -= gameTime.ElapsedGameTime.Milliseconds;
                JumpBar.currentPercentage = (100 - (jumpCounter/5000*100));
            }
            else
            {
                jumpCounter = 0;
                JumpBar.currentPercentage = 100;
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
            carSprite.draw(spriteBatch, graphics);
            tankSprite.draw(spriteBatch, graphics);

            spriteBatch.DrawString(myFont, (counter/1000).ToString(), new Vector2(graphics.PreferredBackBufferWidth/2, 20), Color.Black);

            jumpBar.draw(spriteBatch, graphics);
            
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
