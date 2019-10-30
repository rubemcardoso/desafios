# REFACTOR MEI Fácil

Neste desafio você deverá resolver um problema, muito parecido com um problema real da MEI Fácil.

Trata-se de recriar um pequeno trecho do nosso aplicativo.

Para isso, deve-se utilizar tecnologias `JavaScript` para a resolução do problema.

> *Sugestão*: Use o nosso aplicativo e entenda a regra de negócios na prática!

## O Problema

A sua tarefa é recriar o cadastro e listagens do produto `Link de Pagamento`.

Este produto é bem simples! Se um MEI quiser cobrar seus clientes por cartão, ele pode configurar cobrança no nosso aplicativo.

Nessa cobrança ele deverá informar alguns campos como: 

- Nome completo do cliente;
- Email do cliente;
- Descrição do produto ou serviço;
- Valor do serviço;
- Número de parcelas que o MEI aceita receber o serviço do seu cliente; (de 1 a 15)
- Data de vencimento desta intenção de recebimento;

Na pasta `images`, temos as telas capturadas, que vão ser o guia para a criação do _layout_.

### TELA 01

<center>
  <img src="https://raw.githubusercontent.com/meifacil/desafios/master/REFACTOR/images/01.png" alt="drawing" width="400"/>
</center>

- Saldo a ser liberado. (Obtido através de um endpoint do `Back-End`, a regra é somar todas as cobranças que estejam liberadas);
- O botão transferir pode ser ignorado;
- 2 listagens:
  - A liberar (Lista de cobranças que que ainda não foram liberadas);
  - A vencer (Lista de cobranças que que vão vencer);
  - Pode-se ignorar (Atrasados e Cancelados, utiliando dados mocados); 
- Um botão para iniciar uma nova cobrança. (Dá início ao processo de captura dos dados);

## TELAS DE 02 A 07

<center>
  <img src="https://raw.githubusercontent.com/meifacil/desafios/master/REFACTOR/images/02.png" alt="drawing" width="400"/>
  <br><br>
  <img src="https://raw.githubusercontent.com/meifacil/desafios/master/REFACTOR/images/03.png" alt="drawing" width="400"/>
  <br><br>
  <img src="https://raw.githubusercontent.com/meifacil/desafios/master/REFACTOR/images/04.png" alt="drawing" width="400"/>
  <br><br>
  <img src="https://raw.githubusercontent.com/meifacil/desafios/master/REFACTOR/images/05.png" alt="drawing" width="400"/>
  <br><br>
  <img src="https://raw.githubusercontent.com/meifacil/desafios/master/REFACTOR/images/06.png" alt="drawing" width="400"/>
  <br><br>
  <img src="https://raw.githubusercontent.com/meifacil/desafios/master/REFACTOR/images/07.png" alt="drawing" width="400"/>
  <br><br>
</center>

- Paras as `TELAS` de `02` até `07`, temos os campos a serem obtidos para a criação de uma nova cobrança;

## TELA 08

<center>
  <img src="https://raw.githubusercontent.com/meifacil/desafios/master/REFACTOR/images/08.png" alt="drawing" width="400"/>
</center>

- A `TELA 08` representa um resumo dos campos digitados;

## TELA 09

<center>
  <img src="https://raw.githubusercontent.com/meifacil/desafios/master/REFACTOR/images/09.png" alt="drawing" width="400"/>
</center>

- A `TELA 09` representa sucesso na operação;

## TELA 10

<center>
  <img src="https://raw.githubusercontent.com/meifacil/desafios/master/REFACTOR/images/10.png" alt="drawing" width="400"/>
</center>

- A `TELA 10` representa a listagem de cobranças a liberar;

## TELA 11

<center>
  <img src="https://raw.githubusercontent.com/meifacil/desafios/master/REFACTOR/images/11.png" alt="drawing" width="400"/>
</center>

- A `TELA 11` representa a listagem de cobranças a vencer;

---

Será necessário pensar em uma estrutura de banco de dados para armazenar os requisitos em questão.

Crie um `Front-End` que se comunique com um `Back-End`, seguindo as instruções:

## Front-End

Para a criação do `Front-End` será necessário utilizar (no mínimo) as seguintes tecnologias:

- ReactJS;
- axios;
- styled-components;
- redux;
- thunk;

### Pontos importantes:

- Organize a estrutura em componentes;
- Tenha atenção ao reaproveitamento dos componentes;
- Faça serviços para chamadas externas (api);
- Lembre-se da responsividade (Não é necessário um layout para desktop, mas que seja adaptável a diversos dispositivos móveis);
- Fique atento aos detalhes: é necessário reproduzir de forma fiel o layout apresentado;
- Lembre-se das validações dos campos;
- Mostre as mensagens recebidas da API;
- Pode-se utilizar outras tecnologias complementares que forem necessárias para o desenvolvimento da solução;

## Back-End

Crie um `Back-End` em NodeJS, utilizando as seguintes tecnologias:

- express;
- express-validator;
- sequelize;
- mssql;
- swagger;

### Pontos importantes:

- Crie a documentação da sua API utilizando o Swagger;
- A documentação deve ficar disponível em `/swagger`;
- Valide as entradas vindas do Front-End;
- Utilize os relacionamentos do Sequelize;
- Arquitete o seu código para utilização de `Controllers` e `Models`;
- Crie um arquivo separado com as `rotas` da aplicação;
- Trate os eventuais erros;
- Devolva mensagens amigáveis para o `Front-End`;

## Banco de Dados

Toda a estrutura deve ser armazenada em um banco de dados `SQLServer`.

É necessário utilizar os conceitos de `migrations` e `seed` para criação e inicialização do banco.

## Testes

Utilize o `jest` para a criação de testes para `Front-End` e `Back-End`.

## Infra

Deve-se prever toda a infraestrutura necessária para a execução de cada um dos projetos utilizando a tecnologia Docker;

> Dica: crie um docker-compose para instanciar os serviços necessários.

## Entrega

A entrega deverá ser feita em duas pastas separadas:

- front-end
- back-end

Em cada pasta crie no `package.json` os seguintes comandos:

- `yarn run composer:up` -> deve iniciar o docker-compose; (back-end)
- `yarn run db:up` -> deve chamar os scripts de migrations e seeds; (back-end)
- `yarn test` -> deve rodar os testes;
- `yarn start` -> deve iniciar a aplicação;

> Os comandos serão executados nessa ordem no momento da correção do teste.

# Bônus

Como desafio complementar:

## Front-End

- Utilize conceitos de `PWA` para aprimorar a experiência do usuário em dispositivos móveis:
  - Cache dos arquivos;
  - Cache das chamadas à API's externas;
  - Aplicativo instalável;

## Back-End

- Insira os patterns de `Service` e `Repository` no seu aplicativo;

# Prazo

É dado 4 dias a partir da confirmação de recebimento do teste, que deve ser feita enviando um e-mail para: diogo.batista@meifacil.com

# Forma de Entrega

Realize um `PULL-REQUEST` neste repositório com a sua solução.

Crie um arquivo `README.md` na raiz do seu projeto, documentando a sua tragetória de implementação.