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
        SpriteFont myFont;
        GridCell[,] grid;

        const int gridSize = 32;

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
            base.Initialize();
            
            grid = new GridCell[graphics.PreferredBackBufferWidth / gridSize, graphics.PreferredBackBufferHeight / gridSize];
            
            for (int i = 0; i < graphics.PreferredBackBufferWidth / gridSize; i++)
            {
                for (int j = 0; j < graphics.PreferredBackBufferHeight / gridSize; j++)
                {
                    grid[i, j] = new GridCell(this);
                    grid[i, j].setLocation(i * gridSize, j * gridSize);
                    grid[i, j].setSize(gridSize, gridSize);
                }
            }
            
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

            // TODO: Add your update logic here

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
            //Primitives2D.DrawRectangle(spriteBatch, new Rectangle(10, 10, 40, 40), Color.Yellow);

            for (int i = 0; i < graphics.PreferredBackBufferWidth / gridSize; i++)
            {
                for (int j = 0; j < graphics.PreferredBackBufferHeight / gridSize; j++)
                {
                    grid[i, j].draw(spriteBatch, graphics);
                }
            }

                    spriteBatch.DrawString(myFont, "Breadth-First Search", new Vector2(graphics.PreferredBackBufferWidth/2, 20), Color.Black);
            
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
