using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    class BookShopMain
    {
        static void Main(string[] args)
        {
            GoldenEditionBook book=new GoldenEditionBook("Pod igoto","Ivan Vazov",25.50m);
            Console.WriteLine(book);
            Book booook = new Book("Geracite","Elin Pelin",20.00m);
            Console.WriteLine(booook);
            GoldenEditionBook first = new GoldenEditionBook("ddd", "dd", 22);
            Console.WriteLine(first);
        }
    }
}
