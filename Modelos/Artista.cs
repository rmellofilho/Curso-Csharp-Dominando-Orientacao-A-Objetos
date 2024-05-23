namespace Alura.Filmes{
    class Artista
    {
        public string Nome { get; }
        public int Idade { get; }
        public List<Filme> FilmesAtuados { get; set; }
        public int QuantidadeDeFilmes => FilmesAtuados.Count;
        
        public Artista(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            FilmesAtuados = new List<Filme>();
        }

        public void AdicionarFilme(Filme filme)
        {
            FilmesAtuados.Add(filme);
            if(!filme.Elenco.Contains(this))
            {
                filme.AdicionarElenco(this);
            }
        }

        public void MostrarFilmesAtuados()
        {
            if(this.FilmesAtuados.Count == 0)
            {
                Console.WriteLine($"Nenhum filme encontrado na base para {this.Nome}");
                return;
            } 
            else
            {
                Console.WriteLine($"Filmes de {this.Nome}:");
                foreach(var filme in FilmesAtuados)
                {
                    Console.WriteLine($"Filme: {filme.Titulo}");
                }
            }
            
        }

    }
}