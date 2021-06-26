namespace pcBuilder.Motherboards
{
    public abstract class MotherboardBase
    {
        public abstract Sockets Socket { get; }

        public IProccesor CPU { get;  } 

        public MotherboardBase()
        {

        }
    }
}