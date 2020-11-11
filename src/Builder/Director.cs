namespace Builder {
    public class Director {
        public void MontarVeiculo(VeiculoBuilder builder){
            builder.BuildMotor();
            builder.BuildPortas();
            builder.BuildPeneus();
        }
    }
}