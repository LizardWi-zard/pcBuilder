using System;
using System.Collections.Generic;
using System.Text;

namespace pcBuilder.Motherboards
{
    class MotherboardIntel1212 : MotherboardBase
    {
        public override Sockets Socket { get; }

        private MotherboardIntel1212()
        {
            Socket = Sockets.Intel1212;
        }
    }
}
