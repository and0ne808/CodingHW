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
        public Node[,] nodes; // all nodes in the world
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
            nodeQueue = new Queue<Node>();

            Console.WriteLine(rows + " " + columns);
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
            start.setColor(Color.Red);
            target.setColor(Color.Green);

            //Enqueue the "start" node
            nodeQueue.Enqueue(start);

            //Set the distance to all nodes to infinity (i.e. Int32.MaxValue)
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (nodes[i, j] == start)
                    {
                        Console.WriteLine("You found the start node and set it's distance to zero");
                        nodes[i, j].distance = 0;
                    }
                    else
                    {
                        nodes[i, j].distance = Int32.MaxValue;
                    }
                }
            }

            //While the queue is not empty
            while (nodeQueue.Count != 0)
            {
                //Dequeue the first node in the Queue as the current node
                currentNode = nodeQueue.Dequeue();
                currentNode.visited = true;
                currentNode.setColor(Color.Orange);

                //if the current node is the goal node
                if (currentNode == target)
                {
                    //Success!  We have found the shortest path!  Exit
                    Console.WriteLine("We have found the target node!");
                    currentNode.Print();
                }
                else
                {
                    currentNode.getEdges(this);
                    //Console.WriteLine(currentNode.neighborStack.Count);
                    //for each of the current node's neighbors
                    for(int i = 0; i < currentNode.neighborStack.Count; i++)
                    {
                        distanceToNeighbor = 1;
                        currentNeighbor = currentNode.neighborStack.Pop();

                        //if the neighbor has been visited (i.e. placed in the Queue) ignore it (we've already seen the shortest path to this neighbor)
                        if(currentNeighbor.visited == false)
                        {
                            //calculate the distance of this neighbor through the current node (distance to current node + edge to neighbor)
                            currentNeighbor.distance = currentNode.distance + distanceToNeighbor;

                            //mark this neighbor as "visited"
                            currentNeighbor.visited = true;
                            currentNeighbor.setColor(Color.White); //Set visited neighbors to white

                            //set its back-pointer to the current node
                            currentNeighbor.backPtr = currentNode;

                            //add this neighbor to the Queue
                            nodeQueue.Enqueue(currentNeighbor);
                        }
                    }
                }

            }

            //Print Result
            while (currentNode != null)
            {
                //currentNode.backPtr.item.Print();
                if(currentNode.backPtr == null)
                {
                    Console.WriteLine("Back Pointer is null");
                }
                currentNode.Print();
                currentNode.setColor(Color.Yellow);
                currentNode = currentNode.backPtr;
            }
            start.setColor(Color.Red);
            target.setColor(Color.Green);

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

            //Node startNode = new Node(game, start.iValue + 1, start.jValue + 1);

            myQueue.Enqueue(start);

            while (myQueue.Count != 0)
            {
                currentNode = myQueue.Dequeue();

                if(currentNode.iValue == target.iValue && currentNode.jValue == target.jValue)
                {
                    break;
                }

                currentNode.getEdges(this);
                while(currentNode.neighborStack.Count != 0)
                {
                    currentNeighbor = currentNode.neighborStack.Pop();
                    if (currentNeighbor.distance == Int32.MaxValue)
                    {
                        currentNeighbor.distance = currentNode.distance + 1;
                        currentNeighbor.backPtr = currentNode;
                        myQueue.Enqueue(currentNeighbor);
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
            

            /*
            for(int i = 0; i < 3; i++)
            {
                currentNode.setColor(Color.Pink);
                currentNode = currentNode.backPtr;
            }
            */


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
