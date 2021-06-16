using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.Example3
{
    public class AESEncryptionAlgorithm : IEncryptionAlogirthm
    {
        public void Send(string message)
        {
            Console.WriteLine("AES Encryption Algorithm");
        }
    }
}
