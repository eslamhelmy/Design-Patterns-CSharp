using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    interface Iterator<T>
    {
        bool HasNext();
        T Current();
        void Next();
    }
}
