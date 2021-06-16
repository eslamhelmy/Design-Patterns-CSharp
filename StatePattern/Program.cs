using StatePattern.Example2;
using System;

namespace StatePattern
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StatePattern.Example3.Context ctx = new StatePattern.Example3.Context();
            ctx.Send("test", new StatePattern.Example3.AESEncryptionAlgorithm());
        }

    }
}
