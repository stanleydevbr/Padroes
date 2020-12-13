using System;
namespace Observer
{
    public class Venda : Observer
    {
        private bool _state = false;
        private Balanco _balanco;
        public Venda(Balanco balanco)
        {
            this._balanco = balanco;
        }

        public void Iniciar(){
            if(!_state)
                Console.WriteLine("Venda iniciada...");
            else
                Console.WriteLine("Não posso iniciar venda pois balanço está em andamento");
        }

        public override void Update()
        {
            _state = _balanco.State;
        }
    }
}