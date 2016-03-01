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

        public int iValue;
        public int jValue;
        public Edge[] edges;
        public int m_numOfEdges; // number of edges originating at this node

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
        }

        public void setIJvalue(int newI, int newJ)
        {
            iValue = newI;
            jValue = newJ;
        }

        public void getEdges(Graph graph)
        {
            m_numOfEdges = 0;
            if(graph.nodes[iValue, jValue - 1] != null) //Get Adjacent Node to North
            {
                edges[m_numOfEdges] = new Edge(this, graph.nodes[iValue, jValue - 1], 1);
            }
        }

         
    }
}
