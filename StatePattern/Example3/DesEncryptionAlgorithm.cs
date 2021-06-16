using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.Example3
{
    public class DesEncryptionAlgorithm : IEncryptionAlogirthm
    {
        public void Send(string message)
        {
            Console.WriteLine("DES Encryption Algorithm");
        }
    }
}
