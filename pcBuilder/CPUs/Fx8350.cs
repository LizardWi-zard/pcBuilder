﻿namespace pcBuilder.CPUs
{
    class Fx8350 : IProccesor
    {
        int IProccesor.Frequency { get => 4000; }

        int IProccesor.CoreCount { get => 8; }

        int IProccesor.TDP { get => 95; }

        Sockets IProccesor.Socket { get => Sockets.AmdAM3; }
    }
}
