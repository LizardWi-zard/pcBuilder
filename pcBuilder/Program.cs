using System;
using pcBuilder.Motherboards;
using pcBuilder.CPUs;

namespace pcBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            MotherboardAM3 motherboardAM3 = new MotherboardAM3();
            motherboardAM3.CPU = new Fx8350();
            Console.WriteLine(motherboardAM3.CPU);

            MotherboardAM4 motherboardAM4 = new MotherboardAM4();
            motherboardAM4.CPU = new Fx8350();
            Console.WriteLine(motherboardAM4.CPU);
        }
    }
}
