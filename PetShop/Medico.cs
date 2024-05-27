namespace Desafio.Primeiro.PetShop;
internal class Medico
{
    public string Nome { get; }
    public string Especialidade { get;}
    public Medico(string nome, string especialidade)
    {
        Nome = nome;
        Especialidade = especialidade;
    }
}