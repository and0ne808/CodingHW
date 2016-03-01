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
        public Queue<Node> nodeQueue;
        public Node currentNode;
        public Node currentNeighbor;
        public int distanceToNeighbor;

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

        public void breadthFirstSearch(Node start, Node target)
        {
            //Enqueue the "start" node
            nodeQueue.Enqueue(start);

            //Set the distance to all nodes to infinity (i.e. Int32.MaxValue)
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    nodes[i, j].distance = Int32.MaxValue;
                }
            }

            //While the queue is not empty
            while (nodeQueue.Count != 0)
            {
                //Dequeue the first node in the Queue as the current node
                currentNode = nodeQueue.Dequeue();
                currentNode.visited = true;

                //if the current node is the goal node
                if (currentNode == target)
                {
                    //Success!  We have found the shortest path!  Exit
                }
                else
                {
                    //for each of the current node's neighbors
                    for(int i = 0; i < currentNode.edgeStack.Count; i++)
                    {
                        distanceToNeighbor = currentNode.edgeStack.Peek().m_cost;
                        currentNeighbor = (currentNode.edgeStack.Pop()).m_endNode;

                        //if the neighbor has been visited (i.e. placed in the Queue) ignore it (we've already seen the shortest path to this neighbor)
                        if(currentNeighbor.visited == false)
                        {
                            //calculate the distance of this neighbor through the current node (distance to current node + edge to neighbor)
                            currentNeighbor.distance = currentNode.distance + distanceToNeighbor;

                            //mark this neighbor as "visited"
                            currentNeighbor.visited = true;

                            //set its back-pointer to the current node
                            currentNeighbor.backPtr = currentNode;

                            //add this neighbor to the Queue
                            nodeQueue.Enqueue(currentNeighbor);
                        }
                    }
                }

            }
        }
    }
}
