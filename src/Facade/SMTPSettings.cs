namespace Facade
{
    public class SMTPSettings
    {
        private string _serverName;

        public string ServerName
        {
            get { return _serverName; }
            set { _serverName = value; }
        }

        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
