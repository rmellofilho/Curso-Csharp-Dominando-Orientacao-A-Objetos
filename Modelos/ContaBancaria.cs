class ContaBancaria
{
    protected double Saldo { get; set; }
    
    public ContaBancaria(double saldoInicial = 0)
    {
        Saldo = saldoInicial;
    } 

    public virtual void Depositar(double valor)
    {
        if(valor > 0)
        {
            Saldo += valor;
        }
        else
        {
            throw new ArgumentException("O valor do depósito deve ser maior que 0.");
        }
    }
    public virtual void Sacar(double valor)
    {
        if (valor > 0)
        {
            if (Saldo > valor)
            {
                Saldo -= valor;
            }
            else{
                throw new ArgumentException("Saldo insuficiente.");
            }
        }
        else
        {
            throw new ArgumentException("O valor de saque deve ser maior que 0.");
        }
    }
    public virtual double CalcularSaldo()
    {
        return Saldo;
    }
}