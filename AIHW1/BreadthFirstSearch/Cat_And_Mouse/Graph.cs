using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AI_HW
{
    class Graph
    {
        public Node[,] nodes; // all nodes in the world
        public GraphicsDeviceManager graphics;
        public int cellSize;
        public Game game;
        public int rows;
        public int columns;
        public Queue<Node> nodeQueue;
        public Node currentNode;
        public Node currentNeighbor;
        public int distanceToNeighbor;
        public SpriteBatch spriteBatch;

        public void initialize(GraphicsDeviceManager graphicsDM, int gridSize, Game myGame, SpriteBatch sb)
        {
            spriteBatch = sb;
            graphics = graphicsDM;
            cellSize = gridSize;
            game = myGame;
            rows = graphics.PreferredBackBufferWidth / cellSize;
            columns = graphics.PreferredBackBufferHeight / cellSize;
            nodes = new Node[rows, columns];
            nodeQueue = new Queue<Node>();

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

        public void AndrewBreadthFirst(Node start, Node target)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    nodes[i, j].distance = Int32.MaxValue;
                    nodes[i, j].backPtr = null;
                }
            }

            Queue<Node> myQueue = new Queue<Node>();
      
            start.distance = 0;

            myQueue.Enqueue(start);

            while (myQueue.Count != 0)
            {

                currentNode = myQueue.Dequeue();
                currentNode.setColor(Color.Yellow);

                if (currentNode.iValue == target.iValue && currentNode.jValue == target.jValue)
                {
                    break;
                }

                currentNode.getEdges(this);
                while (currentNode.neighborStack.Count != 0)
                {
                    currentNeighbor = currentNode.neighborStack.Pop();
                    if (currentNeighbor.distance == Int32.MaxValue)
                    {
                        currentNeighbor.distance = currentNode.distance + 1;
                        currentNeighbor.backPtr = currentNode;
                        myQueue.Enqueue(currentNeighbor);
                        currentNeighbor.setColor(Color.Orange);
                    }
                }

            }


            while (currentNode != start)
            {
                currentNode.setColor(Color.Pink);
                currentNode = currentNode.backPtr;
            }
            start.setColor(Color.Red);
            target.setColor(Color.Green);


        }
       
        public void printAllNodes()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    nodes[i, j].Print();
                }
            }
        }
    }
}
