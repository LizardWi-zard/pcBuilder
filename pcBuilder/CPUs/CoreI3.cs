namespace pcBuilder.CPUs
{
    class CoreI3 : IProccesor
    {
        int IProccesor.Frequency { get => 3200; }

        int IProccesor.CoreCount { get => 4; }

        int IProccesor.TDP { get => 95; }

        Sockets IProccesor.Socket { get => Sockets.Intel1212; }
    }
}
