namespace pcBuilder.CPUs
{
    class Ryzen9 : IProccesor
    {
        int IProccesor.Frequency { get => 4500; }

        int IProccesor.CoreCount { get => 16; }

        int IProccesor.TDP { get => 95; }

        Sockets IProccesor.Socket { get => Sockets.AmdAM4; }
    }
}
