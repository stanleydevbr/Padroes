namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            // concrete subject
            Balanco balanco = new Balanco();
            // Concrete observer
            Venda venda = new Venda(balanco);
            balanco.Attach(venda);
            // add os observadores
            balanco.Iniciar();
            //balanco.Finalizar();
            // pode vender?
            venda.Iniciar();
        }
    }
}
