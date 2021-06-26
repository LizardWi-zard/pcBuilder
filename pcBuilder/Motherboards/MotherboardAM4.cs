using System;
using System.Collections.Generic;
using System.Text;

namespace pcBuilder.Motherboards
{
    class MotherboardAM4 : MotherboardBase
    {
        public override Sockets Socket { get; }

        private MotherboardAM4()
        {
            Socket = Sockets.AmdAM4;
        }
    }
}
