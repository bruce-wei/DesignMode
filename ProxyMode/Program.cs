using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyMode
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolGirl girl = new SchoolGirl {Name = "Hui zi"};
            Proxy proxy = new Proxy(girl);
            proxy.GiveFlowers();
            proxy.GiveCholocate();
            proxy.GiveDolls();

            Console.ReadKey();
        }
    }
}
