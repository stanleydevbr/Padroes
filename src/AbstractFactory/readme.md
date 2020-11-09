# Exemplo do padrão de projeto 'Abstract Factory'

## Intenção
Fornecer uma interface para criar famílias de objetos relacionados ou dependentes sem especificar suas classes concretas.

## Descrição
Neste padrão, a fábrica (conhecida com Factory) recebe solicitações por objetos concretos a partir de um cliente. Este padrão pode ser utilizado quando um sistema de software precisa ser independente de como classes concretas (produtos) são criadas, compostas ou representadas. No padrão, uma fábrica fica responsável por encapsular a criação de uma família de produtos. Nesse caso, um cliente precisa conhecer somente as interfaces desses produtos, não a sua implementação, aumentando assim o encapsulamento e abstração. 

## Benefícios
A aplicação deste padrão traz como benefício principla o isolamento de classes concretas. Se for necessário trocar uma família inteira de produtos, esse processo se torna menos impactante nas demais partes do sistema, pois as classes produtos ficam isoladas e não expõem sua implementação a classe cliente, diminuindo o acoplamento.

## Frequência do uso: Nível 5

## Participantes:
* `Abstract Factory` - Declara uma interface para operações que criam objetos produtos abstratos
* `Concrete Factory` - Implementa as operações que criam objetos produtos concretos;
* `Abstract Product` - Define um objeto produto a ser criado pela correspondente fábrica concreta que implementa a interface de Abstract Product;
* Client - Usa somente as interface declaradas pelas classes Abstract Factory e Abstract Product;

## Exemplo: 
Supndo que temos que construir um controle de acesso a dados para dois tipos de bancos distintos, SQL Server e Oracle. 