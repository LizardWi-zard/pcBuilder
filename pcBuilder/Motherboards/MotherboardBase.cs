using System;

namespace pcBuilder.Motherboards
{
    public abstract class MotherboardBase
    {
        public abstract Sockets Socket { get; }

        public RamType RamType { get; protected set; }

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