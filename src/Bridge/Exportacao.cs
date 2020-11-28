namespace Bridge
{
    public abstract class Exportacao {
        public ExportacaoImplementor Implementor { private get; set; }
        public virtual void Exportar(){
            Implementor.Exportar();
        }
    }    
}