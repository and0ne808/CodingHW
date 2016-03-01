using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Cat_And_Mouse
{
    class Node : GridCell
    {
        //protected Node[] adjacent; //adjacency list

        public int iValue; //X node coordinate
        public int jValue; //Y node coordinate
        public Edge[] edges;
        public int m_numOfEdges; // number of edges originating at this node
        public bool visited;
        public int distance;
        public Stack<Edge> edgeStack;
        public Stack<Node> neighborStack;
        //public Edge backPtr;
        Game thisGame;
        //public BackPointer backPtr;
        public Node backPtr;

        public Node(Game game)
            : base(game)
        {
            x = 0;
            y = 0;
            width = 0;
            height = 0;
            color = Color.Gray;
            iValue = 0;
            jValue = 0;
            edges = new Edge[4];
            m_numOfEdges = 0;
            visited = false;
            edgeStack = new Stack<Edge>();
            //backPtr = new BackPointer();
            thisGame = game;
            neighborStack = new Stack<Node>();

        }
        public Node(Game game, int rowNumber, int columnNumber)
    : base(game)
        {
            x = 0;
            y = 0;
            width = 0;
            height = 0;
            color = Color.Gray;
            iValue = rowNumber;
            jValue = columnNumber;
            edges = new Edge[4];
            m_numOfEdges = 0;
            visited = false;
            edgeStack = new Stack<Edge>();
            //backPtr = new BackPointer();
            thisGame = game;
            neighborStack = new Stack<Node>();

        }

        public void setIJvalue(int newI, int newJ)
        {
            iValue = newI;
            jValue = newJ;
        }

        public void getEdges(Graph graph)
        {
            if(graph.nodes[iValue, jValue].jValue - 1 >= 0) //Get Adjacent Node to North
            {
                neighborStack.Push(graph.nodes[iValue, jValue - 1]);
                //graph.nodes[iValue, jValue - 1].setColor(Color.Pink); //color the neighbor pink
            }
            if (graph.nodes[iValue, jValue].jValue + 1 < graph.columns) //Get Adjacent Node to South
            {
                neighborStack.Push(graph.nodes[iValue, jValue +1]);
                //graph.nodes[iValue, jValue + 1].setColor(Color.Pink); //color the neighbor pink
            }
            if (graph.nodes[iValue, jValue].iValue - 1 >= 0) //Get Adjacent Node to West
            {
                neighborStack.Push(graph.nodes[iValue - 1, jValue]);
                //graph.nodes[iValue - 1, jValue].setColor(Color.Pink); //color the neighbor pink
            }
            if (graph.nodes[iValue, jValue].iValue + 1 < graph.rows) //Get Adjacent Node to East
            {
                neighborStack.Push(graph.nodes[iValue + 1, jValue]);
                //graph.nodes[iValue + 1, jValue].setColor(Color.Pink); //color the neighbor pink
            }
        }

        public void Print()
        {
            Console.Write("[");
            Console.Write(iValue);
            Console.Write(", ");
            Console.Write(jValue);
            Console.Write("]");
            Console.WriteLine();
        }

        public void printNeighborStack()
        {
            Console.Write("Number of Neighbors: ");
            Console.WriteLine(neighborStack.Count);
        }


    }
}
