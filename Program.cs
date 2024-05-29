class Program
{
    static void Main(string[] args)
    {
        ContaCorrente cc = new(1000, 5);
        ContaPoupanca cp = new(1000, 0.05);

        cc.Depositar(500);
        Console.WriteLine($"Saldo após depósito da Conta Corrente: {cc.CalcularSaldo()}");
        cc.Sacar(500);
        Console.WriteLine($"Saldo após sacar da Conta Corrente: {cc.CalcularSaldo()}");


        cp.Depositar(500);
        Console.WriteLine($"Saldo após depósito da Conta Poupança: {cp.CalcularSaldo()}");
        cp.Sacar(500);
        Console.WriteLine($"Saldo após sacar da Conta Poupanca: {cp.CalcularSaldo()}");
    }
}