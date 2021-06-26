namespace pcBuilder.CPUs
{
    class CoreI7 : IProccesor
    {
        int IProccesor.Frequency { get => 3800; }

        int IProccesor.CoreCount { get => 8; }

        int IProccesor.TDP { get => 95; }

        Sockets IProccesor.Socket { get => Sockets.Intel1234; }
    }
}
