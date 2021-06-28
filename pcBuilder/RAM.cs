using System;
using System.Collections.Generic;
using System.Text;

namespace pcBuilder
{
    public abstract class RAM
    {
        public CapacityInGb Capacity { get; protected set; }

        public int Frequency { get; protected set; }
        
        public RamType Type { get; protected set; }
    }

    public enum RamType
    {
        DDR3,
        DDR4
    }

    public enum CapacityInGb
    {
        _4,
        _8,
        _16
    }
}
