Atividades do dia 25/03/24 aprendendo C#.

Criando Objetos

Agora que definimos a primeira classe, podemos criar instâncias de objetos deste tipo;

Customer: O tipo da variavel é a especificação do tipo objeto;

Customer: variavel objeto criada na memoria.

var customer = new Customer();

Customer customer = new Customer();


Podemos declarar uma variavel utilizando a palavra reservada var;

var define um tipo implicito de variavel que é fortemente tipada de acordo com a especificação de chamada do construtor da variavel;

Objetos são tipo referenciados:

Objetos guardam um ponteiro de memoria para os dados e não os dados em si mesmos;

Diferente dos tipos de dados por valor, que armazenam os dados diretamente;

Observe o código, qual o valor de i1?

int i1;
i1 = 42;
int i2 = i1;
i2 = 2

i1 = 42   i2 = 2

E agora quando operamos com Objetos?

C1 atribui o nome de Bilbo;
C2 é criado como uma copia de c1, um ponteiro;
C2 altera o nome para Frodo;
Resultado: Tanto c1 quanto c2 possuem o nome Frodo;

var c1 = new Customer();
c1.FirstName = "Bilbo";

var c2 = c1
c2.FirstName = "Frodo";