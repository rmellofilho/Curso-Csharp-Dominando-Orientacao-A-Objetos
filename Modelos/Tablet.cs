class Tablet : Eletronico
{
    public Tablet(string modelo, double preco, string tipoDeTela) : base(modelo, preco)
    {
        TipoDeTela = tipoDeTela;
    }

    public string TipoDeTela { get; set; }

    public override string ExibirInformacoes()
    {
        return $"{base.ExibirInformacoes()} | Tipo de tela: {TipoDeTela}";
    }
}