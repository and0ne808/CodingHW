﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Threading;

namespace AI_HW
{
    /// <summary>
    /// Andrew Day's Breadth First Search
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Graph myGraph;

        bool searched = false;
        bool pressed = false;

        const int gridSize = 32; //size of squares for grid

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = 1024;
            graphics.PreferredBackBufferHeight = 768;
            IsMouseVisible = true;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            base.Initialize();

            myGraph = new Graph();
            myGraph.initialize(graphics, gridSize, this, spriteBatch);         
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
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
            //EXIT APPLICATION
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            //START NEW SEARCH
            if (Keyboard.GetState().IsKeyDown(Keys.Space) && searched == true && pressed == false)
            {
                myGraph = new Graph();
                myGraph.initialize(graphics, gridSize, this, spriteBatch);
                searched = false;
                pressed = true;
            }
            if (Keyboard.GetState().IsKeyUp(Keys.Space) && pressed == true)
            {
                pressed = false;
            }

            while (searched == false)
            {
                
                Random rnd = new Random();
                myGraph.AndrewBreadthFirst(myGraph.nodes[rnd.Next(0,31), rnd.Next(0,23)], myGraph.nodes[rnd.Next(0,31), rnd.Next(0,23)]);
                searched = true;
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

            spriteBatch.Begin();

            myGraph.draw(spriteBatch, graphics);
            
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
