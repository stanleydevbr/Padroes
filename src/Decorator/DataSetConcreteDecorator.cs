using System;
namespace Decorator
{
    public class DataSetConcreteDecorator: DataSetDecorator
    {
        public override void Write(){
            Console.WriteLine("Método DataSetConcreteDecorator.Write() Chamado");
            this.DataSetBase.Write();
        }

        public void WriteXML(){
            Console.WriteLine("Método DataSetConcreteDecorator.WriteXML() Chamado");
        }
        
    }
}