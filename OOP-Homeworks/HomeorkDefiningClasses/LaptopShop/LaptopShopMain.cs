using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class LaptopShopMain
    {
        static void Main(string[] args)
        {
            Battery firstBattery = new Battery("liom", 56, 456);
            Laptop first = new Laptop("Asus", 22, "lll","ddhdhd",0,"envi",56,"sdsd",firstBattery);
            Console.WriteLine(first);
        }
    }
}
