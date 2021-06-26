using System;
using System.Collections.Generic;
using System.Text;

namespace pcBuilder.Motherboards
{
    public class MotherboardIntel1234 : MotherboardBase
    {
        public override Sockets Socket { get; }

        private IProccesor _CPU;

        public override IProccesor CPU
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

        public MotherboardIntel1234()
        {
            Socket = Sockets.Intel1234;
        }
    }
}
