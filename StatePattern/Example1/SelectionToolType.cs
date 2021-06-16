using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class SelectionToolType : IToolType
    {
        public string MouseDown()
        {
            return $"mouse down is pressed on selection";
        }

        public string MouseUp()
        {
            return $"mouse up is fired on selection";

        }
    }
}
