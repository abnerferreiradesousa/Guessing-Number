# Boas-vindas ao repositório do Adivinhe o Número.

Abaixo estão as regras de negócio seguidas durante o desenvolvimento desse Desafio Agregador.

# Requisitos

Uma empresa que desenvolve aplicações de console contatou você com uma problemática: `Todos os sistemas desta empresa têm filas longas e as pessoas clientes ficam entediadas enquanto esperam`.
  
  - Você, então, proativamente, propõe a solução de implementar um jogo para os clientes se divertirem enquanto esperam sua vez na fila.
  - A empresa gostou e aceitou, o jogo escolhido então foi o `Adivinhe o Número!`

Então você recebeu a tarefa de implementar esse jogo clássico!

As regras do jogo são bem simples:
- O jogador 1 escolhe um número aleatório;
- O jogador 2 tenta adivinhar esse número;
- O jogador 1 responde se a tentativa do jogador 2 foi correta, abaixo ou acima do número escolhido.
-Essa sequência se repete até que o jogador 2 acerte o número.

Seguindo os requisitos desse projeto, vamos construir nosso adversário, o jogador 1:
 
## 1 - Imprima uma mensagem e receba a resposta da pessoa usuária.
_Crie a lógica do seu requisito no arquivo src/`guessing-number/GuessingGame.cs`._

<details>
  <summary>Ao ser executado, a primeira ação do programa deverá ser imprimir uma mensagem de boas-vindas!</summary><br/>

 A mensagem deverá ser exatamente:
 ```
 "---Bem-vindo ao Guessing Game---"
 "Para começar, tente adivinhar o número que eu pensei, entre -100 e 100!"
 ```
  
 > Crie essa lógica na função `Greet()`

</details>

<details>
  <summary>Em seguida, o programa deve esperar a entrada da pessoa usuária e armazená-la na variável `response`.</summary><br />

> Se a pessoa usuária não inserir um número **inteiro**, ou se ele inserir um número **fora do range** (-100, 100), o programa deve imprimir a mensagem: `"Por favor, digite um número inteiro:"`
> 
    > E esperar uma nova entrada da pessoa usuária **até** a pessoa usuária inserir um número válido.
  
</details>

<details>
  <summary>O programa deve, então, converter a entrada da pessoa usuária em um tipo `int` e armazenar na variável `userValue`.</summary><br />

> Crie essa lógica na função `ChooseNumber()`
  
</details>

Você sempre pode executar o programa usando
`dotnet run` na pasta `scr/guessing-number`.

<details>
  <summary> Criar os testes do <strong> primeiro</strong> requisito</summary><br/>

> Deve ser feito em `src/guessing-number.Test/TestFirstReq.cs`
- Se o programa **imprime a mensagem correta**
  > Crie essa lógica na função `TestPrintInitialMessage()`
- Se o programa **recebe a entrada da pessoa usuária**
  > Crie essa lógica na função `TestReceiveUserInputAndConvert()`
- Se o programa **faz a validação do tipo `int`**
  > Crie essa lógica na função `TestReceiveUserInputAndVerifyType()`
- Se o programa **faz a validação do range `-100 e 100`**
  > Crie essa lógica na função `TestReceiveUserInputAndVerifyRange()`

</details>

## 2 - O programa deve escolher um número aleatório.
_Crie a lógica do seu requisito no arquivo src/`guessing-number/GuessingGame.cs`._

<details>
  <summary>O programa agora deve escolher um número aleatório `entre -100 e 100` e armazenar na variável `randomValue`.</summary><br/>

> Dica: use a função `random.GetInt(x, y)` para escolher números aleatórios.
> Crie essa lógica na função `RandomNumber()`

</details>

<details>
  <summary>Agora, o programa deverá comparar a entrada da pessoa usuária com o número aleatório e analisá-lo</summary><br />

- **Se** a entrada for **maior** que o número aleatório, o programa deverá imprimir a mensagem: `Tente um número MENOR`
- **Se** a entrada for **menor** que o número aleatório, o programa deverá imprimir a mensagem: `Tente um número MAIOR`
- **Se** a entrada for **igual** ao número aleatório, o programa deverá imprimir a mensagem: `ACERTOU!`
> Crie essa lógica na função `AnalyzePlay()`
 
</details>

<details>
  <summary> Criar os testes do <strong>segundo</strong> requisito</summary><br/>

> Deve ser feito em `src/guessing-number.Test/TestSecondReq.cs`
  - Se o programa **escolhe um número aleatório entre -100 e 100**
    > Crie essa lógica na função `TestRandomlyChooseANumber()`
  - Se o programa **compara corretamente a entrada e o número escolhido**
    - para quando o número da pessoa usuária é **menor**
      > Crie essa lógica nas funções `TestProgramComparisonValuesLess()`
    - para quando o número da pessoa usuária é **maior**
      > Crie essa lógica nas funções `TestProgramComparisonValuesBigger()`
    - para quando a pessoa usuária **acertar**
      > Crie essa lógica nas funções `TestProgramComparisonValuesEqual()`

</details>

## 3 - O programa deverá repetir a operação de escolha da pessoa usuária
_Crie a lógica do seu requisito no arquivo src/`guessing-number/GuessingGame.cs`._

<details>
  <summary>Se a pessoa usuária errar o número aleatório, seja para `MAIOR`, seja para `MENOR`, o programa deve receber uma nova tentativa.</summary><br/>

> Lembre-se das validações do número de entrada.

</details>

<details>
  <summary>O programa deve repetir esse procedimento **até** a pessoa usuária acertar o número escolhido aleatoriamente.</summary><br />

> Se você implementou corretamente as funções `ChooseNumber()` e `AnalyzePlay()`, esse requisito irá funcionar; caso contrário, é legal rever essas funções.
 
</details>

<details>
  <summary> Criar os testes do <strong>terceiro</strong> requisito</summary><br/>

> Deve ser feito em `src/guessing-number.Test/TestThirdReq.cs`
  - Se o programa **repete o comportamento até a pessoa usuária acertar.**
    > Crie essa lógica na função `TestFullFlow()`

</details>

# Exemplo

Um exemplo da execução do programa é:
Para um fluxo correto! 
```
---Bem-vindo ao Guessing Game---
Para começar, tente adivinhar o número que eu pensei, entre -100 e 100!
"10"
Tente um número MENOR
"0"
Tente um número MENOR
"-50"
Tente um número MAIOR
"-30"
Tente um número MAIOR
"-21"
ACERTOU!
```

Para um fluxo com verificações de tipo e range!
```
---Bem-vindo ao Guessing Game---
Para começar, tente adivinhar o número que eu pensei, entre -100 e 100!
"teste"
Por favor, digite um número inteiro:
"nao"
Por favor, digite um número inteiro:
"10"
Tente um número MAIOR
"1000"
Por favor, digite um número inteiro:
"50"
Tente um número MAIOR
"77"
ACERTOU!
```


 A partir deste projeto, você poderá se aprofundar nos contextos básicos de C#. Além disso, vai aprender, por meio da prática, sobre o  fluxo de controle de uma aplicação.  

Vamos lá!? Nos vemos quando você acertar o número!✅

---
