namespace FactoryMethod
{
    public class LinkedinCreator: ICreator
    {
        public IAutenticacao CreateInstance()
        {
            return new AutenticacaoLinkedin();
        }
    }
}