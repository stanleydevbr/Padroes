using System;

namespace TemplateMethod
{
    public class CorrecaoRedacao : Correcao
    {
        private string _redacao = "Redação";
        public override void Corrigir()
        {
            Console.WriteLine($"Corrigindo {_redacao}");
        }

        public override void EnviarDadosParaBancoDeDados()
        {
            Console.WriteLine($"Enviando os dados de {_redacao} para a base de dados");
        }

        public override void Iniciar()
        {
            Console.WriteLine($"Iniciando a correção da {_redacao}...");
        }

        public override void LimparCorrecoesAnteriores()
        {
            Console.WriteLine($"Limpando dados da {_redacao} anterior...");
        }

        public override void VerificarPrerequisitos()
        {
            Console.WriteLine($"Verificando os pré-requisitos de correção da {_redacao}");
        }
    }
}
