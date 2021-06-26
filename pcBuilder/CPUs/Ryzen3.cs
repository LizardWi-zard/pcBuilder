namespace pcBuilder.CPUs
{
    class Ryzen3 : IProccesor
    {
        int IProccesor.Frequency { get => 3500; }

        int IProccesor.CoreCount { get => 4; }

        int IProccesor.TDP { get => 95; }

        Sockets IProccesor.Socket { get => Sockets.AmdAM4; }
    }
}
