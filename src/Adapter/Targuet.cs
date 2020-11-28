using System;
namespace Adapter
{
    public class Targuet
    {
        public virtual void Request()
        {
            Console.WriteLine("Método Request da targuet chamado");
        }
    }


}