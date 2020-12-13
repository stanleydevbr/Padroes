using System;

namespace TemplateMethod
{
    public class CorrecaoProva : Correcao
    {
        private string _prova = "Prova";
        public override void Corrigir()
        {
            Console.WriteLine($"Corrigindo {_prova}");
        }

        public override void EnviarDadosParaBancoDeDados()
        {
            Console.WriteLine($"Enviando os dados da {_prova} para o banco de dados");
        }

        public override void Iniciar()
        {
            Console.WriteLine($"Iniciando a correção da {_prova}");
        }

        public override void LimparCorrecoesAnteriores()
        {
            Console.WriteLine($"Limpando correções da {_prova} anterior");
        }

        public override void VerificarPrerequisitos()
        {
            Console.WriteLine($"Verificando os pré-requisitos de correção da {_prova}");
        }
    }
}
