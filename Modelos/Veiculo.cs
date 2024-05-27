using System.Dynamic;

namespace OficinaAutomobilistica;

 public class Veiculo
{
    private List<OrdemDeServico> servicosExecutados = new();
    
    public Veiculo(string marca, string modelo, int ano, string placa, Cliente dono)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        Placa = placa;
        Dono = dono;

        if (!dono.AdicionarVeiculo(this))
        {
            throw new InvalidOperationException("Veículo com a mesma placa já existe para este cliente.");
        }

        Console.WriteLine($"Veículo adicionado com sucesso:\n{InformacoesVeiculo}");
    }

    public string Marca { get; }
    public string Modelo { get; }
    public int Ano { get; }
    public string Placa { get; }
    public Cliente Dono { get; }
    public List<OrdemDeServico> ServicosExecutados => servicosExecutados;
    public string InformacoesVeiculo => $"Marca: {this.Marca} | Modelo: {this.Modelo} | Ano: {this.Ano} | Placa: {this.Placa} | Dono: {this.Dono.Nome}";

    public void ExibirServicosExecutados()
    {
        Console.WriteLine($"Serviços executados no veículo [{this.InformacoesVeiculo}]:");
        for(int servico = 0; servico < ServicosExecutados.Count; servico++)
        {
            Console.WriteLine($"\n{servico+1}");
            ServicosExecutados[servico].ExibirOrdemDeServico();
        }

    }
}