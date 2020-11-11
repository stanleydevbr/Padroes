namespace Builder{

    public abstract class VeiculoBuilder{
        protected Veiculo _veiculo;
        public Veiculo Veiculo { get {return _veiculo;}  }

        public abstract void BuildMotor();
        public abstract void BuildPortas();
        public abstract void BuildPeneus();
        

    }
}