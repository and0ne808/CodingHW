using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cat_And_Mouse
{
    class BackPointer
    {
         public Node item;

        public BackPointer(ref Node point)
        {
            item = point;
        }
        public BackPointer()
        {
            item = null;
        }
        public void Change(ref Node newNode)
        {
            item = newNode;
        }
    }

}
