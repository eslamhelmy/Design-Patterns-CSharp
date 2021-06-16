using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.Example2
{
    public class Drive : ITravelMode
    {
        public int GetDirection()
        {
            return 10;
        }

        public int GetEta()
        {
            return 10;
        }
    }
}
