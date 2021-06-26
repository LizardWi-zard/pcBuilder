namespace pcBuilder.Motherboards
{
    public abstract class MotherboardBase
    {
        public abstract Sockets Socket { get; }

        public virtual IProccesor CPU { get; set; } 

        public MotherboardBase()
        {

        }
    }
}