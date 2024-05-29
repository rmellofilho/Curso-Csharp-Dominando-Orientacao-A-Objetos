class Ave : Animal
{
    public Ave(string nome) : base(nome)
    {
    }

    public override string EmitirSom()
    {
        return "Som de ave";
    }
}