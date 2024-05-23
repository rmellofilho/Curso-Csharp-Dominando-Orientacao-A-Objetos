Nesta aula introduzimos uma nova classe Avaliacao para que ela pudesse isolar tanto o dado primitivo com o valor da nota (usamos um inteiro para representá-la) quanto possíveis comportamentos do conceito de avaliação em nossa aplicação (por exemplo a capacidade de transformar um texto em um objeto através do método estático Parse(). Um tipo muito comum em projetos C# criado com esta mesma finalidade é o DateTime. Seu objetivo é representar um momento no tempo e fornecer comportamentos para lidar com datas, horas, conversões, dentre outros.

Um comportamento que pode ser inserido nestes tipos é a habilidade de validar valores que estão fora do limite permitido. No caso de uma nota, citei que um valor negativo para uma banda faria com que ela fosse rebaixada no carnaval daquela temporada :-). Notas muito grandes também não fariam sentido e impactariam o cálculo da média, impossibilitando a comparação entre bandas.

Agora é sua vez! Na classe Avaliacao, crie uma regra de negócio para não permitir que notas menores que zero sejam registradas. Além disso, notas maiores que dez também não podem ser registradas.

Considere que valores inteiros fora da faixa recebem os limites inferior e superior. Ou seja:

Notas menores que zero são zero;
Notas maiores que dez são dez.