using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Cat_And_Mouse
{
    class Edge
    {
        public Edge(Node startNode = null, Node endNode = null, int cost = 1)
        {
            m_startNode = startNode;
            m_endNode = endNode;
            m_cost = cost;
        }
        public Node m_startNode;
        public Node m_endNode;
        public int m_cost;
    }
}
