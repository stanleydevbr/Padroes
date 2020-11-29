using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var formulario = new Formulario("Cadastro de pessoas");
            formulario.Add(new Button("Novo"));
            formulario.Add(new Button("Gravar"));
            formulario.Add(new Button("Cancelar"));
            formulario.Add(new Button("Excluir"));
            formulario.Add(new Button("Anterior"));
            formulario.Add(new Button("Proximo"));
            formulario.Add(new Button("Sair"));
            formulario.Add(new TextBox("Nome"));
            formulario.Add(new TextBox("CPF"));
            formulario.Add(new TextBox("Telefone"));
            formulario.Add(new TextBox("e-mail"));
            formulario.Display();            
        }
    }
}
