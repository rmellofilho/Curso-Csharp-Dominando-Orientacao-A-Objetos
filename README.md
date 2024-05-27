Estes foram os pontos principais abordados nesta aula:
Conhecemos uma boa prática que é embrulhar tipos primitivos em conceitos maiores, permitindo adicionarmos comportamentos como validação, tradução e quaisquer outras operações;

Aprendemos que também as classes podem ter sua visibilidade modificada pelas palavras reservadas internal e public. Classes internal só podem ser vistas dentro de um projeto. Já classes public são vistas por qualquer projeto que as referencie.

Compreendemos que quando um método não acessa informações dos objetos da classe onde está declarado, pode ser indicado como estático. Basta usar a palavra reservada static em sua assinatura. E para ser invocado, usamos o modelo Tipo.MetodoEstatico(). Exemplos de métodos estáticos que já vínhamos usando desde os primeiros cursos: Console.WriteLine(), int.Parse(), Thread.Sleep(), Console.Clear(), dentre outros.

Revelamos um segredo da Microsoft no arquivo Program.cs. Ele também é uma classe que possui um método estático chamado Main(), indicado para representar o ponto de entrada de qualquer programa .NET. O motivo pelo qual a Microsoft escolheu esconder esta classe foi para reduzir a curva de aprendizado aos iniciantes na linguagem. Legal né?!