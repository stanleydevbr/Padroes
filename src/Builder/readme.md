# Padrão de projeto BUILDER

## Intenção
<p>
Separa a construção de um objeto complexo da sua representação, de modo que o mesmo processo de construção pode criar diferentes representações.
</p>

## Descrição
<p>
O padrão pode ser aplicado quando o algoritimo para a construção de um objeto deve ser independente das partes que o compõem e de como elas são montadas. O processo de construção deve permitir diferentes representações para o objeto que é construído.
</p>

## Benefícios
<p>
A aplicação deste padrão traz alguns benefícios, como permitir variar a representação interna de u produto, pois uma interface permite ao construtor ocultar essa representação. O padrão melhora a modularidade pelo encapsulamento da forma como um objeto complexo é construído e representado. Em outras palavras, ele isola o código da construção.
</p>

### Frequência de uso nível 2

## Participantes
<ul>
    <li>Builder - Especifica uma interface abstrata para a criação de partes de um objeto-produto;</li>
    <li>Concret Builder - Constrói e monta partes do produto pela implementação da interface de Builder; define e mantém a representação que cria e fornece uma interface para a recuperação do produto;</li>
    <li>Diretor - Contrói um objeto usando a interface de Builder;</li>
    <li>Product - Representa o objeto complexo em construção, concrete Builder contrói a representação interna do produto e define o processo pelo qual ele é montado, 
    inclui classes que definem as partes constituintes, inclusive as interfaces para a montagem das partes do resultado final.</li>
</ul>

![description](../images/Builder.png)
