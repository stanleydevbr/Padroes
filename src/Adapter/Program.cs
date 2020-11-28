using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Targuet targuet1 = new Adapter();
            Targuet targuet2 = new Targuet();
            targuet1.Request();            
            targuet2.Request();
        }
    }
}
