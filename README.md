Afirmamos que em nossa carreira de pessoas desenvolvedoras vamos trabalhar em projetos com dezenas e até centenas de classes. Imagina se todas as classes ficassem no mesmo nível de pasta e a cada necessidade de encontrar uma classe você precisasse usar a barra de rolagem? Ou mesmo digitar o nome dela em uma janela de pesquisa em sua IDE favorita? Produtividade é um objetivo essencial no trabalho e uma das maneiras de atingi-la é **organizar os arquivos e classes em pastas diferentes**.

Junto com a separação em pastas, utilizamos outro recurso que nos permite organizar classes: são os **namespaces**. Além da organização, um benefício adicional é conseguir manter dentro do projeto tipos com o mesmo nome. A distinção é feita através da referência ao “nome completo da classe”, ou *Fully Qualified Name* (FQN), que é obtido com a concatenação do namespace com a classe. Por exemplo, o FQN da classe `Musica` no namespace `ScreenSound.Modelos` é `ScreenSound.Modelos.Musica`.

Agora é a sua vez de testar pastas e namespaces em um projeto!

Sua missão agora é criar um projeto do tipo console com duas pastas: `PlataformaA` e `PlataformaB`. Nelas você vai declarar classes de mesmo nome: `Video`. A ideia é representar vídeos com conceitos diferentes, dependendo da plataforma de streaming. Para o objetivo desta atividade, não precisaremos criar propriedades nelas. Declare seus namespaces como a seguir:

- Classe `Video` na pasta PlataformaA: namespace `VideoFlix.PlataformaA`;

- Classe `Video` na pasta PlataformaB: namespace `VideoFlix.PlataformaB`.

Por fim, declare duas variáveis no arquivo `Program.cs` cujos tipos são `Video` da plataforma A e `Video` da plataforma B. Como resolver o conflito de nomes?