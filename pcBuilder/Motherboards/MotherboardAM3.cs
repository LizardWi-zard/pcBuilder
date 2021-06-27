using System;
using System.Collections.Generic;
using System.Text;
using pcBuilder;

namespace pcBuilder.Motherboards
{
    public class  MotherboardAM3 : MotherboardBase
    {
        public override Sockets Socket { get; }

        public MotherboardAM3()
        {
            Socket = Sockets.AmdAM3;
        }
    }
}
