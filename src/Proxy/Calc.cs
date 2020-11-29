namespace Proxy
{
    public class Calc : Proxy.ICalc
    {
        public int Somar(int x, int y)
        {
            return x + y;
        }
    }
}
