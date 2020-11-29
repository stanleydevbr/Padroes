namespace ChainOfResponsability
{
    // Handler
    public abstract class BaseValidate
    {
        protected BaseValidate _sucessor;
        public void setSucessor(BaseValidate sucessor)
        {
            this._sucessor = sucessor;
        }
        public abstract bool ValidateUser(string name, string password);
    }
}
