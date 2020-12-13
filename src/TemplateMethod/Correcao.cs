namespace TemplateMethod
{
    public abstract class Correcao
    {
        public abstract void Corrigir();
        public abstract void VerificarPrerequisitos();
        public abstract void EnviarDadosParaBancoDeDados();
        public abstract void LimparCorrecoesAnteriores();
        public abstract void Iniciar();

        public void Processar(){
            Iniciar();
            VerificarPrerequisitos();
            LimparCorrecoesAnteriores();
            Corrigir();
            EnviarDadosParaBancoDeDados();
        }
    }
}
