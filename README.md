[25/03/24] 
TDD - Test Driven Development
DDD - Domain Driven Development

Dominio - exemplo: banco

POO

Uma abordagem para projetar e construir aplicações que são:

-Flexiveis
-Naturais
-Bem elaboradas
-Testáveis

Focada em objetos que interagem uns com os outros.

Requisitos:

Você recebeu uma solicitação por e-mail de uma amiga veterinária, informando
que está com problemas para gerenciar os atendimentos dos pets. Na mensagem, ela
diz que gostaria de ter registros dos animais, que precisa também dos dados dos seus parceiros veterinários que atendem no centro clinico para poder saber quais
médicos atendenderam quais animais em um determinado período de tempo, ou até mesmo, registrar quais tempo, ou até mesmo, registrar quais procedimentos foram realizados com os animais nos ultimos atendimentos.

Primeiro passo

Inicie com os nomes. ==> Quais são as palavras-chave informadas no requisito que são essenciais para ajudar a resolver o problema de nossa amiga veterinaria?

ficha clinica:

veterinario, pets, parceiros, atendimento, gerenciar, registros dos animais, data do atendimento.



Segundo passo

Defina os membros apropriados.

Quais são as propriedades (dados) e os métodos (operações) fundamentais para iniciar a construção deste software?

Descreva quais as propriedades necessárias para sua proposta pensando nas seguintes entidades.

ANIMAL, VETERINARIO, ATENDIMENTO, CLINICA.

Animal - peso, raça, especie, tamanho, nome do tutor, data de nascimento.
Veterinario - nome do veterinario, idade, especialidade, atendimentos.
Atendimento - nome do atendimento, horario, nome do veterinario, nome do tutor.
Clinica - nome da clinica, endereço, lista de atendimentos. 

Definindo membros apropriados:

Veterinario

- Nome, email, telefone, CRM
- Salva()
- Retornar()

Animal

- Nome, raça, peso, altura, responsável, telefone_responsavel.
- Salvar()
- Retornar()

Atendimento

- Data/Hora, Animal, Veterinario, Observação.
- Salvar()
- Retornar()

O efeito TEMPO

Considere o efeito tempo em sua aplicação, com o passar dos anos os dados podem sofrer alterações, o responsavel por um animal pode mudar, um telefone ou e-mail por exemplo.

O tempo é uma quarta dimensão a ser considerada, se algum dado do veterinario da clinica, ou do animal for alterado, isto influenciaria nos dados armazenados de atendimento?

Utilize sempre os conceitos de abstração e encapsulamento para responder a estas perguntas.

Profundidade, Largura e Altura. x,y,z.

[Abstração:]

O processo de abstração dependerá dos requsitos da aplicação. Em nosso caso, temos a entidade veterinário, onde faz-se necessario registrar poucos dados (nome, email, telefone, CRM) devio ao escopo reduzido do problema, mas se estivessemos modelando um sistema mais robusto para aplicações diversas, certamente precisariamos de mais informações sobre o veterinario, como endereço, especialidade, etc.

É o processo de definir classes simplificando a realidade, ignorando detalhes, desnecessarios e focando apenas no que é relevante ao escopo da aplicação.

É um dos pilares da POO / OOP;

[Encapsulamento:]

Outro pilar da programação OO;

Técnica para 'esconder' os dados e os detalhes da implementação em um classe.

Utilizado para garantir que os outros codigos do sistema não se preocupem em saber os detalhes da implementação.

Estas propriedades são disponibilizadas para o resto do sistema por meio de metodos de gravação e leitura chamados e getters e setters, protegendo os dados e facilitando validação e autorização;


