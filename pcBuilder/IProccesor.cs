using System;
using System.Collections.Generic;
using System.Text;

namespace pcBuilder
{
    interface IProccesor
    {
        int Frequency { get; }
        int CoreCount { get; }
        int TDP { get; }
        Sockets Socket { get; }
    }
}
