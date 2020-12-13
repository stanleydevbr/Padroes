using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria orignator
            Pessoa p = new Pessoa();
            p.State = "Stanley";
            // Mostra o estado original
            Console.WriteLine($"Estado original: {p.State}");
            Caretaker c = new Caretaker();
            c.Memento = p.CreateMemento();
            // trocando o estado...
            p.State = "Stanley Dias";
            // mostra estado atual
            Console.WriteLine($"Estado atual: {p.State}");
            // restaurar o estado original
            p.SetMemento(c.Memento);
            // mostra estado atual
            Console.WriteLine($"Estado restaurado: {p.State}");
        }
    }
}
