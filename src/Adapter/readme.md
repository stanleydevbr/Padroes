##### tags: 'Padrões estruturais'
## ADAPTER
### Intenção
Converter a interface de uma classe em outra interface esperada pelo clientes. Permite que classes trabalhem em conjunto, pois de outra forma não poderiam devido a terem interfaces incompatíveis. 

### Descrição
O padrão pode ser usando quando você quiser usar uma classe existente, mas sua interface não corresponder à interface que necessita; ou quando você quiser criar uma classe reutilizável que coopere com classes não relacionadas ou não-prevista, ou seja classes que não necessariamente tenha interfaces compatíveis; você precisar usar várias subclasses existentes, porém, for impraticável adaptar essas interfaces criando subclasses para cada uma. Um adaptador de objeto pode adaptar a interfaces de sua classe mãe.

### Benefícios
O padrão traz alguns benefícios. Um adaptador de classe adapta *Adaptee* a *Target* através do uso efetivo de uma classe Adapter concreta, com isso permite a *Adapter* substituir algum comportamento do *Adaptee*, uma vez que *Adapter* é uma subclasse de *Adaptee*. Um adaptador de objeto permite a um único Adapter trabalhar com muitos *Adaptees*. O Adapter também pode acrescentar funcionalidades a todos os *Adaptees* de uma só vez.

### Frequência de uso
Nível 4

### Participantes
* **Target** - define a interface específica do domínio que o Cliente usa;
* **Cliente** - colabora com objeto compatível com a interface de Target;
* **Adaptee** - define uma interface existente que necessita ser adptada;
* **Adapter** - adapta a interface do Adaptee à interface do Tarquet;

### Diagrama

<img src="imagens/adapter.png" width = "100%">


