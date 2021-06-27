using System;
using System.Collections.Generic;
using System.Text;

namespace pcBuilder.Motherboards
{
    public class MotherboardAM4 : MotherboardBase
    {
        public override Sockets Socket { get; }

        public MotherboardAM4()
        {
            Socket = Sockets.AmdAM4;
        }
    }
}
