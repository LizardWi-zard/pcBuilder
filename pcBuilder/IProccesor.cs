using System;
using System.Collections.Generic;
using System.Text;

namespace pcBuilder
{
    public interface IProccesor
    {
        //public
        int Frequency { get; }
        int CoreCount { get; }
        int TDP { get; }
        Sockets Socket { get; }
    }
}
