using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace arduinoLib
{
    public class pin
    {
        public int Id
        {
            get;
            private set;
        }

        public pin(int Id)
        {
            this.Id = Id;
        }
    }
}
