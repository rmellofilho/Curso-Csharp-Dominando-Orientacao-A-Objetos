namespace OficinaAutomobilistica;

public class OrdemDeServico
{
    public OrdemDeServico(Veiculo veiculoDoCliente, Mecanico mecanico, string servico, string dataParaEntrega)
    {
        VeiculoDoCliente = veiculoDoCliente;
        Mecanico = mecanico;
        Servico = servico;
        DataParaEntrega = dataParaEntrega;

        veiculoDoCliente.ServicosExecutados.Add(this);
    }
    public Veiculo VeiculoDoCliente { get; }
    public Mecanico Mecanico { get; }
    public string Servico { get; }
    public string DataParaEntrega { get; }

    public void ExibirOrdemDeServico()
    {
        Console.WriteLine($"""
        **Ordem de serviço**
        Veiculo: {VeiculoDoCliente.InformacoesVeiculo}
        Cliente: {VeiculoDoCliente.Dono.Nome}
        Mecânico: {Mecanico.Nome}
        Serviço: {this.Servico}
        Data Para entrega: {this.DataParaEntrega}
        """);
    }
    
}