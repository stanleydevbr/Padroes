using System;
namespace Decorator
{
    public class DataSetDecorator: BaseDataSet
    {
        public BaseDataSet DataSetBase { protected get; set; }
        public override void Write()
        {
            Console.WriteLine("Método DataSetDecorator.Write() Chamado");
            this.DataSetBase.Write();
        }
    }
}