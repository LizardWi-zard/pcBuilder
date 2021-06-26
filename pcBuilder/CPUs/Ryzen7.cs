namespace pcBuilder.CPUs
{
    class Ryzen7 : IProccesor
    {
        int IProccesor.Frequency { get => 4200; }

        int IProccesor.CoreCount { get => 12; }

        int IProccesor.TDP { get => 65; }

        Sockets IProccesor.Socket { get => Sockets.AmdAM4; }
    }
}
