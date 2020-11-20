using System;
namespace FactoryMethod
{
    public class AutenticacaoLinkedin: IAutenticacao
    {
        public void Autenticar(){
            Console.WriteLine("Autenticado pelo linkedin");
        }
    }
    
}