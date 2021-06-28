using System;
using System.Collections.Generic;
using System.Text;

namespace pcBuilder.Motherboards
{
    public class MotherboardIntel1234 : MotherboardBase
    {
        public override Sockets Socket { get; }

        public MotherboardIntel1234()
        {
            Socket = Sockets.Intel1234;
            RamType = RamType.DDR4;
        }
    }
}
