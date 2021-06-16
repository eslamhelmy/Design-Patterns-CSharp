using System;
using System.Collections.Generic;
using System.Text;

namespace Template
{
    public abstract class Window
    {
        public void Close()
        {
            BeforeClose();
            Console.WriteLine("Removing the window from the screen");
            AfterClose();
        }

        protected abstract void BeforeClose();
        protected abstract void AfterClose();

    }
}
