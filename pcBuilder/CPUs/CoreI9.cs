namespace pcBuilder.CPUs
{
    class CoreI9 : IProccesor
    {
        int IProccesor.Frequency { get => 4000; }

        int IProccesor.CoreCount { get => 16; }

        int IProccesor.TDP { get => 125; }

        Sockets IProccesor.Socket { get => Sockets.Intel1234; }
    }
}
