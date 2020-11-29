using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet ds = new DataSet();
            DataSetConcreteDecorator dc = new DataSetConcreteDecorator();
            dc.DataSetBase = ds;
            dc.Write();
            dc.WriteXML();
        }
    }
}
