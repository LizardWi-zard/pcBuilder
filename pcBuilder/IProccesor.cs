﻿using System;
using System.Collections.Generic;
using System.Text;

namespace pcBuilder
{
    public interface IProccesor
    {
        int Frequency { get; }
        int CoreCount { get; }
        int TDP { get; }
        Sockets Socket { get; }
    }
}
