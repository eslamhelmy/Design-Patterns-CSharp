using System;
using System.Collections.Generic;
using System.Text;

namespace Template
{
    public class CustomWindow : Window
    {
        protected override void AfterClose()
        {
            Console.WriteLine("After Close from custom window");
        }

        protected override void BeforeClose()
        {
            Console.WriteLine("Before Close from custom window");
        }
    }
}
