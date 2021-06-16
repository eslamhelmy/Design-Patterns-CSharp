using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.Example3
{
    public class Context
    {
        public void Send(string message, IEncryptionAlogirthm algorithm)
        {
            algorithm.Send(message);
        }
    }
}
