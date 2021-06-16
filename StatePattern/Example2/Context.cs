using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.Example2
{
    class Context
    {
        private ITravelMode mode; 
        public Context(ITravelMode mode)
        {
            this.mode = mode;
        }
        public int GetEta()
        {
            return mode.GetEta();
        }

        public int GetDirection()
        {
            return mode.GetDirection();
        }

    }
}
