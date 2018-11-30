## Loteria

Resolva este exercício na linguagem de programação JavaScript.

Considere que existe um vetor chamado *sorteio* com seis posições, que armazenam números inteiros. Esse vetor representa os números sorteados por uma loteria.


| 0 	| 1 	| 2 	| 3 	| 4 	| 5 	|
|:--:	|:--:	|:--:	|:--:	|:--:	|:--:	|
| 45 	| 13 	| 01 	| 18 	| 33 	| 35 	|

Uma matriz com nome *jogos* é composta por *100* linhas e seis colunas. Cada uma de suas linhas representa um jogo realizado para esta loteria.

|  	    | 0 	| 1 	| 2 	| 3 	| 4 	| 5 	|
|:---:	|:---:	|:---:	|:---:	|:---:	|:---:	|:---:	|
| 0 	| 01 	| 15 	| 17 	| 33 	| 35 	|  59 	|
| 1 	| 03 	| 05 	| 09 	| 33 	| 35 	| 45 	|
| 2 	| 32 	| 33 	| 02 	| 01 	| 40 	| 50 	|
| ... 	| ... 	| ... 	| ... 	| ... 	| ... 	| ... 	|
| 99 	| 01 	| 02 	| 33 	| 34 	| 50 	| 51 	|

Existe ainda uma variável chamada *valor* que representa valor total do prêmio a ser dividido entre os acertadores;

A constante *NUMBERS* representa a quantidade de números jogados. A constante *LINES* representa a quantidade de jogos apostados no sistema.

---

Com base nessas informações, crie um programa para:

1. Retornar a quantidade de jogadores que acertaram *n* números na loteria. Para isso crie uma função conforme o seguinte modelo:

```js
const calculaGanhador = (sorteio, jogos, qtdAcertos) => {
    // implemente aqui
}
```

2. Retornar qual foi o número mais jogado. Para isso crie uma função conforme o seguinte modelo:

```js
const maisJogado = (jogos) => {
    // implemente aqui
}
```

3. Imprimir quais números não foram jogados. Para isso crie uma função conforme o seguinte modelo:

```js
const naoJogados = (jogos) => {
    // implemente aqui
}
```

4. Verificar e mostrar quanto cada acertador irá receber utilizando as regras:

    * 85% do valor do prêmio: dividido entre os jogadores que acertaram 06 dezenas;
    * 10% do valor do prêmio: dividido entre os jogadores que acertaram 05 dezenas;
    * 5\% do valor do prêmio: dividido entre os jogadores que acertaram 04 dezenas;

---

O tempo para a resolução deste exercício é de 60 minutos.

Para entregar o seu código, faça um PULL REQUEST neste repositório com seus arquivos de resposta.

Não é necessário implementar nehuma interface gráfica.