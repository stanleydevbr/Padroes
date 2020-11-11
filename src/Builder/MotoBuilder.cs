namespace Builder {
    public class MotoBuilder : VeiculoBuilder
    {
        public MotoBuilder()
        {
            _veiculo = new Veiculo("Moto");

        }
        public override void BuildMotor()
        {
            _veiculo["motor"] = "250c";
        }

        public override void BuildPeneus()
        {
            _veiculo["pneus"] = "2";
        }

        public override void BuildPortas()
        {
            _veiculo["portas"] = "0";
        }
    }
}