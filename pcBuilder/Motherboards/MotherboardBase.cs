using System;
using System.Collections.Generic;
using System.Linq;

namespace pcBuilder.Motherboards
{
    public abstract class MotherboardBase
    {
        public abstract Sockets Socket { get; }

        public RamType RamType { get; protected set; }

        private IEnumerable<RAM> _RAMSet = new List<RAM>();

        public IEnumerable<RAM> RAMSet { get; protected set; }

        public void AddRam(RAM ram)
        {
            if (RAMSet.Count() < 5 && RamType == ram.Type)
            {
            _RAMSet.Append(ram);
            }
            
        }

        private IProccesor _CPU;

        public virtual IProccesor CPU 
        { 
            get { return _CPU; } 
        
            set 
            {
                if (value.Socket != Socket)
                    throw new InvalidOperationException();
                else
                    _CPU = value;
            }
        } 

        public MotherboardBase()
        {

        }
    }
}