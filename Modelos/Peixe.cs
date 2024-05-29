class Peixe : Animal
{
    public Peixe(string nome) : base(nome)
    {
    }

    public override string EmitirSom()
    {
        return "Som de peixe";
    }
}