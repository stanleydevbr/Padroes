using System;

namespace Interator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria Concrete Aggregate
            Equipe equipe = new Equipe();
            equipe[0] = "Stanley";
            equipe[1] = "Dias";
            equipe[2] = "Paulo";
            equipe[3] = "Marinho";
            equipe[4] = "Jose";
            // Cria Iterator
            ConcreteIterator i = new ConcreteIterator(equipe);
            // iterar pela coleção
            Console.WriteLine("Listando membros da equipe:");
            Object item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }
        }
    }
}