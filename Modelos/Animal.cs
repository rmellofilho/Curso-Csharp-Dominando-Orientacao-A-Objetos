public class Animal
{
    public string Nome { get; set; }
    public Animal(string nome)
    {
        Nome = nome;
    }

    public virtual string EmitirSom()
    {
        return "Som genérico";
    }
}