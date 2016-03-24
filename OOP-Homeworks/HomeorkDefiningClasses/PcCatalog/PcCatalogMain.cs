using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PcCatalog
{
    class PcCatalogMain
    {
        static void Main(string[] args)
        {
            Component first = new Component("Screen", 100);
            Component second = new Component("Keyboard",50);
            Component third=new Component("Mouse",20);
            Component screen = new Component("Screen", 88);
            Component hdd = new Component("Hdd", 123);

            List<Component> firstComponents = new List<Component>()
            {
                first, second, third
            };
            List<Component> secondComponents = new List<Component>()
            {
                first, second, third,screen
            };
            List<Component> thirdComponents= new List<Component>()
            {
               screen,hdd
            };

            Computer firstComputer = new Computer("Asus",firstComponents);
            Computer secondComputer = new Computer("Acer", secondComponents);
            Computer thirdComputer = new Computer("Toshiba", thirdComponents);

            List<Computer> computers = new List<Computer>()
            {
               firstComputer,secondComputer,thirdComputer
            };

            computers = computers.OrderBy(c => c.Price).ToList();

            foreach (var computer in computers)
            {
                Console.WriteLine(computer);
            }
        }
    }
}
