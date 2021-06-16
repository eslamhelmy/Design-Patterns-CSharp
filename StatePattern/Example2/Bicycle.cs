using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.Example2
{
    public class Bicycle : ITravelMode
    {
        public int GetDirection()
        {
            return 40;
        }

        public int GetEta()
        {
            return 30;
        }
    }
}
