using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Cat_And_Mouse
{
    class Graph
    {
        public Node[,] nodes;
        protected int numOfNodes; //number of nodes in the graph
        public GraphicsDeviceManager graphics;
        public int cellSize;
        public Game game;
        public int rows;
        public int columns;

        public void initialize(GraphicsDeviceManager graphicsDM, int gridSize, Game myGame)
        {
            graphics = graphicsDM;
            cellSize = gridSize;
            game = myGame;
            rows = graphics.PreferredBackBufferWidth / cellSize;
            columns = graphics.PreferredBackBufferHeight / cellSize;
            nodes = new Node[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    nodes[i, j] = new Node(game, i, j);
                    nodes[i, j].setIJvalue(i, j);
                    nodes[i, j].setLocation(i * gridSize, j * gridSize);
                    nodes[i, j].setSize(gridSize, gridSize);
                }
            }
        }

        public void draw(SpriteBatch spriteBatch, GraphicsDeviceManager graphics)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    nodes[i, j].draw(spriteBatch, graphics);
                }
            }

        }
    }
}
