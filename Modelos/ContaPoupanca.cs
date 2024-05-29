class ContaPoupanca : ContaBancaria
{
    private double TaxaRendimento { get; set; }
    public ContaPoupanca(double saldoInicial = 0, double taxaRendimento = 0) : base(saldoInicial)
    {
        TaxaRendimento = taxaRendimento;
    }

    public override void Sacar(double valor)
    {
        base.Sacar(valor);
    }
    public override double CalcularSaldo()
    {
        return base.CalcularSaldo() * (1 + TaxaRendimento);
    }
}