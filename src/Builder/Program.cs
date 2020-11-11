using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            VeiculoBuilder builder;
            var diretor = new Director();

            builder = new CarroBuilder();
            diretor.MontarVeiculo(builder);
            builder.Veiculo.Mostrar();

            builder = new MotoBuilder();
            diretor.MontarVeiculo(builder);
            builder.Veiculo.Mostrar();

        }
    }
}
