using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.Example3
{
    public interface IEncryptionAlogirthm
    {
        void Send(string message);
    }
}
