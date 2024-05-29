class Laptop : Eletronico
{
    public string Processador { get; set; }
    public Laptop(string modelo, double preco, string processador) : base(modelo, preco)
    {
        Processador = processador;
    }

    public override string ExibirInformacoes()
    {
        return $"{base.ExibirInformacoes()} | Processador: {Processador}";
    }
}