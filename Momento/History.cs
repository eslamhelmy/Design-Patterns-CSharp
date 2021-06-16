using System;
using System.Collections.Generic;
using System.Text;

namespace Momento
{
    class History
    {
        private Stack<DocumentState> states = new Stack<DocumentState>();

        public DocumentState AddToHistory(DocumentState state)
        {
            states.Push(state);
            return state;
        }

        public DocumentState Undo()
        {
            states.Pop();
            return states.Peek();
        }
    }
}
