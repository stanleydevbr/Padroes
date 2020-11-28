namespace Adapter
{
    public class Adapter: Targuet {
        private Adaptee _adaptee = new Adaptee();

        public override void Request(){
            _adaptee.SpecificRequest();
        }
    }
    
}