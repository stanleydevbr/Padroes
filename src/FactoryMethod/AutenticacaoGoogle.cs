using System;
namespace FactoryMethod
{
    public class AutenticacaoGoogle: IAutenticacao
    {
        public void Autenticar(){
            Console.WriteLine("Autenticado pelo Google");
        }
    }
    
}