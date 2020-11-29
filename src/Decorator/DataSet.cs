using System;

namespace Decorator
{
    public class DataSet : BaseDataSet
    {
        public override void Write()
        {
            Console.WriteLine("Método DataSet.Write() chamado");
        }
    }
}