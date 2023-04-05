using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VovaStroitKust
{
    class TreeElement
    {
        public int[] pos = new int[2];
        public int valueGenerated = 0;
 
        public TreeElement(int x, int y)
        {
            pos[0] = x;
            pos[1] = y;
            //valueGenerated = value;
        }
    }
}
