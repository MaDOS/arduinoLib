using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace arduinoLib
{
    public class uno : arduino
    {
        public uno(string comPort)
            : base(comPort, 14, 6)
        {
            
        }
    }
}
