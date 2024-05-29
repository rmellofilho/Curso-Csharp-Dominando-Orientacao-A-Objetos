class Mamifero : Animal
{
    public Mamifero(string nome) : base(nome)
    {
    }

    public override string EmitirSom()
    {
        return "Som de mamífero";
    }
}