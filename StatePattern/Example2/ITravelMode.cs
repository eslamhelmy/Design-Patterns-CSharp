using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.Example2
{
    public interface ITravelMode
    {
        int GetEta();
        int GetDirection();
    }
}
