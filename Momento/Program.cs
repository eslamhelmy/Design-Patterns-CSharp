using System;

namespace Momento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Document doc = new Document
            {
                Content = "test",
                FontName = "arial",
                FontSize = "14"
            };

            var currentState = doc.CreateState();

            History his = new History();
            var state = his.AddToHistory(currentState);

            doc.Content = "Tessst2";
            state = doc.CreateState();
            his.AddToHistory(state);

            doc.Content = "Tessst3";
            state = doc.CreateState();
            his.AddToHistory(state);

            doc = doc.restore(his.Undo());
           
        }
    }
}
