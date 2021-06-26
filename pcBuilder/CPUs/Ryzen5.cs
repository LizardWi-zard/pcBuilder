namespace pcBuilder.CPUs
{
    class Ryzen5 : IProccesor
    {
        int IProccesor.Frequency { get => 4000; }

        int IProccesor.CoreCount { get => 8; }

        int IProccesor.TDP { get => 65; }

        Sockets IProccesor.Socket { get => Sockets.AmdAM4; }
    }
}
