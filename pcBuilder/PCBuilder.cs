using System;
using System.Collections.Generic;
using System.Text;

namespace pcBuilder.CPUs
{
    class PCBuilder
    {
        PCBuilder()
        {

        }

        private IProccesor CreateCPU(Processors cpu)
        {
            switch (cpu)
            {
                case Processors.CoreI3:
                    return new CoreI3();
                case Processors.CoreI5:
                    return new CoreI5();
                case Processors.CoreI7:
                    return new CoreI7();
                case Processors.CoreI9:
                    return new CoreI9();
                case Processors.Ryzen3:
                    return new Ryzen3();
                case Processors.Ryzen5:
                    return new Ryzen5();
                case Processors.Ryzen7:
                    return new Ryzen7();
                case Processors.Ryzen9:
                    return new Ryzen9();
                case Processors.Fx8350:
                    return new Fx8350();
                case Processors.Fx8390:
                    return new Fx8390();
                default:
                    throw new KeyNotFoundException();
            }
        }

    }
}
