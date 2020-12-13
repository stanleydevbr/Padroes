## MEDIATOR
##### tags: `Padrões de projetos` `Padrões comportamentais`

### Intenção
Definir um objeto que encapsula como um conjunto de objetos interagem. Mediator promove o baixo acoplamento por manter objetos sem se referir um ao outro de forma explícita, e que lhe permite variar sua interação independentemente.

### Descrição
O padrão Mediator pode ser usado quando: um conjunto de objetos se comunica de maneira bem-definida, porém complexas; as interdependência resultantes são desestruturadas e difíceis de entender. A reutilização de um objeto é difícil porque ele referencia e se comunica com muitos outros objetos; um comportamento que está distribuído entre várias classes deveria ser customizável, ou adaptável, sem execessiva especialização em subclasses.

### Benefícios
Limita o uso de subclasses; desacopla colegas; simplifica o protocolo de objetos; abstrai a maneira como os objetos cooperam; ele centraliza o controle

### Frequência de uso 
Nível 2

### Participantes
* **Mediator** - Define uma interface para comunicação com objetos Colleague;
* **ConcreteMediator** - Implementa o comportamento cooperativo;
* **Colleague classes** - Cada classe Colleague conhece seu objeto Mediator de outra forma; cada Colleague se comunica com seu Mediator sempre que, de outra forma, teria que se comunicar com outro colega;

### Diagrama
<img src="imagens/mediator.svg" width = "100%">

### Exemplo
```csharp=
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator mediator = new ConcreteMediator();
            Suporte suporte = new Suporte(mediator);
            Usuario usuario = new Usuario(mediator);
            mediator.Suporte = suporte;
            mediator.Usuario = usuario;
            usuario.Send("Meu Sistema não esta carregando.");
            suporte.Send("E preciso reiniciar o sistema.");
        }
    }

    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    } 

    public abstract class Colleague
    {
        protected Mediator _mediator;
        public Colleague(Mediator mediator)
        {
            this._mediator = mediator;
        }
    }

    public class Suporte : Colleague
    {
        public Suporte(Mediator mediator)
        :base(mediator)
        {}

        public void Send(string message)
        {
            _mediator.Send(message, this);
        }
        public void Notify(string message)
        {
            Console.WriteLine($"Suporte recebeu a mensagem: {message}");
        }
    }

    public class Usuario : Colleague
    {
        public Usuario(Mediator mediator)
        :base(mediator)
        {

        }
        public void Send(string message){
            _mediator.Send(message, this);
        }
        public void Notify(string message)
        {
            Console.WriteLine($"Usuário recebeu a mensagem: {message}");
        }
    }

    public class ConcreteMediator : Mediator
    {
        private Suporte _suporte;
        private Usuario _usuario;
        public Suporte Suporte {
            set {_suporte = value;}
        }

        public Usuario Usuario {
            set {_usuario = value;}
        }

        public override void Send(string message, Colleague colleague)
        {
            if (colleague == _usuario)
                _suporte.Notify(message);
            else
                _usuario.Notify(message);
        }
    }
```