namespace Builder
{
    public class CarroBuilder : VeiculoBuilder
    {
        public CarroBuilder()
        {
            _veiculo = new Veiculo("Carro de Passeio");

        }
        public override void BuildMotor()
        {
            _veiculo["motor"] = "127C";
        }

        public override void BuildPeneus()
        {
            _veiculo["pneus"] = "4";
        }

        public override void BuildPortas()
        {
            _veiculo["portas"] = "4";
        }
    }
}