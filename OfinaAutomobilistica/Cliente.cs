namespace OficinaAutomobilistica;

public class Cliente
{
    private List<Veiculo> veiculos = new();
    public Cliente(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    public List<Veiculo> Veiculos => veiculos;
    
    public bool AdicionarVeiculo(Veiculo veiculo)
    {
        if(veiculos.Any(v => v.Placa == veiculo.Placa))
        {
            Console.WriteLine($"O veículo com a placa {veiculo.Placa} já existe na lista");
            return false;
        }
        veiculos.Add(veiculo);
        return true;
    }

    public void ExibirVeiculos()
    {
        Console.WriteLine($"Veiculos de {this.Nome}:");
        foreach(var veiculo in Veiculos)
        {
           Console.WriteLine($"{veiculo.Placa} | {veiculo.Modelo}"); 
        }
    }
}