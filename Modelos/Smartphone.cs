class Smartphone : Eletronico
{
    public Smartphone(string modelo, double preco, string sistemaOperacional) : base(modelo, preco)
    {
        SistemaOperacional = sistemaOperacional;
    }

    public string SistemaOperacional { get; set; }
    public override string ExibirInformacoes()
    {
        return $"{base.ExibirInformacoes()}, SO: {this.SistemaOperacional}";
    }
}