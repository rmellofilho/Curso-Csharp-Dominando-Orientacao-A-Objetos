using Alura.Filmes;

Artista artista1 = new Artista("ator 1", 23);
Artista artista2 = new Artista("ator 2", 23);

Filme filme1 = new("filme 1", 123, new List<Artista> {artista1});
Filme filme2 = new("filme 2", 133, new List<Artista>());

filme1.AdicionarElenco(artista2);
artista2.AdicionarFilme(filme1);

System.Console.WriteLine();
artista1.MostrarFilmesAtuados();

System.Console.WriteLine();
filme1.ListarElenco();

System.Console.WriteLine();
filme2.AdicionarElenco(artista1);
filme2.AdicionarElenco(artista2);
filme2.ListarElenco();

System.Console.WriteLine();
artista1.MostrarFilmesAtuados();
artista2.MostrarFilmesAtuados();