namespace Facade
{
    public class MailMessage
    {
        private string _message;
        private MailFormat _format;

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public MailMessage(string message, MailFormat format)
        {
            // formatar mensagem aqui...
            this._message = message;
            this._format = format;
        }
    }  
}
