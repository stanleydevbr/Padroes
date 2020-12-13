namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Correcao prova = new CorrecaoProva();
            prova.Processar();
            Correcao redacao = new CorrecaoRedacao();
            redacao.Processar();            
        }
    }
}
