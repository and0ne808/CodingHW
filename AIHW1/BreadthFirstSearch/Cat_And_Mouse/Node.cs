using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace AI_HW
{
    class Node : GridCell
    {
        public int iValue; //X node coordinate in 2D matrix
        public int jValue; //Y node coordinate in 2D matrix

        public int m_numOfEdges; // number of edges originating at this node
        public bool visited;
        public int distance;
        public Stack<Node> neighborStack;
        Game thisGame;
        public Node backPtr;

        public Node(Game game)
            : base(game)
        {
            x = 0;
            y = 0;
            width = 0;
            height = 0;
            color = Color.CornflowerBlue;
            iValue = 0;
            jValue = 0;
            m_numOfEdges = 0;
            visited = false;
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
            color = Color.CornflowerBlue;
            iValue = rowNumber;
            jValue = columnNumber;
            m_numOfEdges = 0;
            visited = false;
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
            }
            if (graph.nodes[iValue, jValue].jValue + 1 < graph.columns) //Get Adjacent Node to South
            {
                neighborStack.Push(graph.nodes[iValue, jValue +1]);
            }
            if (graph.nodes[iValue, jValue].iValue - 1 >= 0) //Get Adjacent Node to West
            {
                neighborStack.Push(graph.nodes[iValue - 1, jValue]);
            }
            if (graph.nodes[iValue, jValue].iValue + 1 < graph.rows) //Get Adjacent Node to East
            {
                neighborStack.Push(graph.nodes[iValue + 1, jValue]);
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

        public void PrintNumberOfNeighbors()
        {
            Console.Write("Number of Neighbors: ");
            Console.WriteLine(neighborStack.Count);
        }


    }
}
