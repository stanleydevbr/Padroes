namespace FactoryMethod
{
    public interface ICreator
    {
        IAutenticacao CreateInstance();
    }
}