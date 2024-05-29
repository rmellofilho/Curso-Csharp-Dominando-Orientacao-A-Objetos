class ContaCorrente : ContaBancaria
{
    private double TaxaManutencao { get; set; }
    public ContaCorrente(double saldoInicial = 0, double taxaManutencao = 0) : base(saldoInicial)
    {
        TaxaManutencao = taxaManutencao;
    }
    public override void Sacar(double valor)
    {
        base.Sacar(valor + TaxaManutencao);
    }
}