[dia 01/04/2024]:

Classes identificadas:

- Customer:

name, 
email adress,
home adress,
work adres,
-validate()
-retrieve()
-save()

- Product:

product name
description
current price
-validate()
-retrieve()
-save()


- Order:

-Customer
-Order date
shipping adress
order item
-validate()
-retrieve()
-save()

- Order Item:

product
quantity
purchase price
-validate()
-retrieve()
-save()

====================

Termos: Assinatura do metedo

-Composto pelo nome e conjunto de parametros e seus tipos;
-Não inclui o tipo de retorno;
-Utilizado pelo sistema para orientar as chamadas;

Sobrecarga/Overloading

Usado para descrever metodos que possuem o mesmo nome com diferentes parametros;
Metodos que são expecificados com o mesmo nome, devem prover variações da mesma funcionalidade;
No eemplo, um metodo retorna um Customer, enquanto o outro retorna uma coleção de consumidores List<Customer>;
Utilize void quando não houver nada a retornar;

Contract

As especificações dos modificadores de acesso definem o contrato da clase. Quais atributos e metodos estarão visiveis, para quem e em que nivel de acesso;

pode ser public, private, protected.

Counstrutores:

Um tipo especial de metodo com o mesmo nome da classe;
Geralmente definindo no primeiro paragrafo da clae;
É o metodo executado quando um objeto do tipo da clase é criado;
Um metodo construtor sem parametros é definido com construtor padrão(default constructor);
Podemos fazer a sobrecarga(overloading) de construtores;

Sobrecarga é forçar uma segunda assinatura na classe já existente;

Responsabilidade:

Mantenha 

KISS Keep It Simple, Stupid!
YAGNI You Arent Gonna Need It
DRY Dont repeat yourself

[15/04/2024]: Aula continuação

POCO Plain Old C# Object.

Repositor e Pattern.

ORM - Object Relational Mapping.

Framework que abstrai o trabalho de conectar no banco de dados.
Entity Framework.