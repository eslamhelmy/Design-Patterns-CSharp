using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class EraserToolType : IToolType
    {
        public string MouseDown()
        {
            return $"mouse down is pressed on eraser";
        }

        public string MouseUp()
        {
            return $"mouse up is fired on eraser";

        }
    }
}
