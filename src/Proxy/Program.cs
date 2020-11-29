using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalc calc = new CalcProxy();
            var r = calc.Somar(3, 5);
            Console.WriteLine(r.ToString());
        }
    }
}
