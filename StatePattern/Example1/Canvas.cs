using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.Example1
{
    class Canvas
    {
        public IToolType Type { get; set; }
        public string MouseUp()
        {
            return Type.MouseUp();
        }

        public string MouseDown()
        {
            return Type.MouseDown();
        }
    }
}
