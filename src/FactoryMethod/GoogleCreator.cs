
namespace FactoryMethod
{
    public class GoogleCreator: ICreator
    {
        public IAutenticacao CreateInstance()
        {
            return new AutenticacaoGoogle();
        }
    }
}